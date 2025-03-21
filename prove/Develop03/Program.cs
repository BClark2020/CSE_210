/// Brenden Clark
/// Programming with Classes
/// 03/20/2025
/// 
/// reasources used:
///     --Scripture CSV file: https://scriptures.nephi.org/
///     --ChatGPT: Speciffically for parsing information from the CSV file
///                and helping me detect puncuation. Also helped me find a
///                way to make key strokes inputs.
///
/// 
/// 
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


class Program
{
    static void Main()
    {
        Search _BCsearch = new Search();
        Word _BCword = new Word();
        Program _BCprogram = new Program();
        
        string _BCscripture_location;
        string _BCverse;
        int _BCword_drop = 1; 
        bool _BCend = false;
        bool _BCrepeat = false;

        do
        {
            do
               {
                    _BCscripture_location = _BCsearch.BC_get_scripture_cite(); 

                    _BCverse = _BCsearch.BC_get_verses();
                
                    if (_BCverse != "false")
                    { 
                        _BCend = true;
                        _BCword_drop = _BCword.BC_get_word_drop_rate();
                    }


                    else
                    {
                        _BCend = false;
                    }

               } while(_BCend == false);

               
               _BCprogram.BC_run_word_removal(_BCword_drop, _BCscripture_location, _BCverse);
               
               _BCrepeat = _BCprogram.BC_get_repeat();

        } while( _BCrepeat == true);

        Console.Clear();
        Console.WriteLine("Thank you for using scripture memorizer app today!");
       
    }
    public bool BC_get_repeat()
    {
        bool _BCrepeat = false;
        Console.Clear();
        Console.WriteLine("Can you recite it all?");

        List<string> _BCaccepted_responses = new List<string>{"Yes", "yes", "y", "Y", "No", "no", "N","n"};
            bool _BCbool = false;
            string _BCresponse = "";
            do
            {
            try
            {
                Console.Write("Would you like to memorize another scripture? ");
                _BCresponse = Console.ReadLine();
                if (!_BCaccepted_responses.Contains(_BCresponse))
                {
                    throw new ArgumentException("Sorry that is an invalid input");
                }
                else
                {
                    _BCbool = false;
                }
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error" + ex.Message);
                _BCbool = true;
            }
        } while (_BCbool == true);

        if (_BCresponse == "Yes" || _BCresponse == "yes" || _BCresponse == "y" || _BCresponse == "Y")
            
            {
                _BCrepeat = true;
            }

        return _BCrepeat;
    }
    public void BC_run_word_removal(int _BCword_drop, string _BCscripture_location, string _BCverse)
    {
        Program _BCprogram = new Program();
        Word _BCword = new Word();
        string _BCpause_code = "";
        List<string> _BCpassage = new List<string>(_BCword.BC_word_parse(_BCverse));
        int _BCrange = _BCpassage.Count();
        bool _BCend = false;

        while (_BCword._BCremoved_indexes.Count() < _BCpassage.Count() && _BCend != true)
            {
    
                if (_BCpause_code == "end")
                {
                    _BCend = true;
                }

                else
                {
                    _BCword.BC_display(_BCpassage, _BCscripture_location);
                    _BCpause_code = _BCprogram.BC_pause_button_functions();
                }
                

                if (_BCpause_code == "reveal")
                {
                   _BCpassage = _BCword.BC_restore_word(_BCpassage, _BCword_drop);
                }

                else
                {
                    _BCword.BC_word_removal(_BCpassage, _BCword_drop);
                }
            }
    }
    public string BC_pause_button_functions()
    {
        string _BCpause = "";
      
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.Enter)
        {
                _BCpause = "yes";
        }
        else if (keyInfo.Key == ConsoleKey.Backspace)
        {
            _BCpause = "reveal";
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            _BCpause = "end";
        }
        
        return _BCpause;
    }
}