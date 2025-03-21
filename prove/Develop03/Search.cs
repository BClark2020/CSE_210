using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;


class Search
{ 
    private List<int> _BCscripture_range = new List<int>{1}; 
    private bool _BC_verse_range = false;
    private string _BCbook;
    private int _BCverse_int;
    public string BC_get_scripture_cite()
    {   
        bool _BCend = false;
        string _BCscripture_location;
        _BCscripture_range.Clear();

        do 
        {
            Console.Clear();
            Console.WriteLine("Welcome to scripture memorizer!");
            Console.Write("What is the scripture (example: Genesis 1:1): ");
            _BCscripture_location = Console.ReadLine();
            _BCscripture_location = _BCscripture_location.Trim();
            _BCend = false;


            
    
                // Regular expression to extract the book, chapter, and verse/range
                Regex regex = new Regex(@"^(?<BookChapter>[^\d]*\d*[\w\s]* \d+):(?<VerseRange>\d+(-\d+)?)$");
                Match match = regex.Match( _BCscripture_location);

                if (match.Success)
                {
                    _BCbook = match.Groups["BookChapter"].Value.Trim();
                    string verseRange = match.Groups["VerseRange"].Value;

                    // Check if it's a range of verses
                    if (verseRange.Contains("-"))
                    {
                    

                        string[] rangeParts = verseRange.Split('-');
                        if (rangeParts.Length == 2 && int.TryParse(rangeParts[0], out int startVerse) && int.TryParse(rangeParts[1], out int endVerse))
                        {
                            

                            if (startVerse > endVerse)
                            {
                                Console.WriteLine("Invalid verse range. Please enter a valid range.");
                                Thread.Sleep(2500);
                                _BCend = true;
                            }
                            else
                            {
                                _BCscripture_range = GenerateRange(startVerse, endVerse);
                                _BC_verse_range = true;
                                _BCend = false; 
                            }
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid verse range. Please enter a valid range.");
                            _BCend = true;
                        }
                    }
                    else if (int.TryParse(verseRange, out int verse))
                    {
                        _BCverse_int = verse;
                        _BC_verse_range = false;
                        _BCend = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid verse. Please enter a valid verse.");
                        _BCend = true;
                        Thread.Sleep(2500);
                    }
                }
                else
                {
                
                    Console.WriteLine("Invalid input format. Please enter a reference in the format 'Book Chapter:Verse' or 'Book Chapter:StartVerse-EndVerse'.");
                    Thread.Sleep(2500);
                    _BCend = true;
                }
            
        } while (_BCend);
     
        return _BCscripture_location;
    }  
    static List<int> GenerateRange(int start, int end)
    {
        List<int> numbers = new List<int>();
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }
        return numbers;
    }
    public string BC_get_verses()
    {
        string _BCverse = "";
        int _BC_last_verse;
        int _BC_first_verse; 
        bool _BCresults = false;
        bool _BCindex_18 =  false;
        Console.Clear();
        Console.WriteLine($"Loading:");
        int _BC_verse_location;
        

        if (_BC_verse_range == true)
        {
            _BC_last_verse = _BCscripture_range[_BCscripture_range.Count() - 1];
            _BC_first_verse = _BCscripture_range[0];
        }
        else
        {
            _BC_first_verse = _BCverse_int;
            _BC_last_verse = _BCverse_int;
        }

        for (int i = 0; i < _BC_last_verse - _BC_first_verse + 1; i++)
        {
            if (_BC_verse_range == true)
            {
                _BC_verse_location =  _BCscripture_range[i];
            }
            else
            {
                _BC_verse_location = _BCverse_int;
            }

            string _BCscripture_location = _BCbook + ":"+ _BC_verse_location;
            
            Console.WriteLine($"{_BCscripture_location}");


         
            if (_BCindex_18 == false)
                {
                    using (TextFieldParser _BCparser = new TextFieldParser("lds-scriptures.csv"))
                    {
                        _BCparser.TextFieldType = FieldType.Delimited;
                        _BCparser.SetDelimiters(",");
                        _BCparser.HasFieldsEnclosedInQuotes = true;

                        while (!_BCparser.EndOfData)
                        {   
                        
                            string[] fields = _BCparser.ReadFields();

                            if (fields[17] == _BCscripture_location)
                            {     
                                _BCverse += " " + fields[16];
                                _BCresults = true;

                            }

                        }
                        if (_BCresults == false)
                        {  
                            _BCindex_18 = true;
                        }

                    }
                }



            if (_BCindex_18 == true)
            {
                using (TextFieldParser _BCparser = new TextFieldParser("lds-scriptures.csv"))
                {
                    _BCparser.TextFieldType = FieldType.Delimited;
                    _BCparser.SetDelimiters(",");
                    _BCparser.HasFieldsEnclosedInQuotes = true;

                    while (!_BCparser.EndOfData)
                    {   
                    
                        string[] fields = _BCparser.ReadFields();

                        if (fields[18] == _BCscripture_location)
                        {     
                            _BCverse += " " + fields[16];
                            _BCresults = true;

                        }

                    }


                }

            }

            if (_BCresults == false)
            {  
                Console.WriteLine("Invalid input or scripture doesn't exist, please try again!");
                _BCverse = "false";
                Thread.Sleep(2500);
                return _BCverse;
            }
        }


        return _BCverse;
    }
}
