
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        Fraction frac= new Fraction();
        bool loop = true;
        bool _var;
        while(loop)
        {
            Console.Clear();
            Console.Write("1.) Set Top\n2.) Set bottom\n3.) Display Fraction\n4.) Exit Program");   
            string _option = Console.ReadLine();
            Thread.Sleep(200);
            
            switch(_option)
            {
                case "1":
                _var = false;
                do{
                    try
                    {
                        Console.Clear();
                        Console.Write("Top value: ");
                        int _top = int.Parse(Console.ReadLine());
                        Thread.Sleep(100);
                        frac.SetTop(_top); 
                        _var =  false;
                    }  catch (FormatException)
                    {
                        _var = true;
                        Console.WriteLine("ERROR: Pleas enter an int value."); 
                        Thread.Sleep(3000);
                    }
                }while(_var);
                break;
                
                case "2":
                _var = false;
                do{
                try
                {
                    Console.Clear();
                    Console.Write("Bottom Value: ");
                    int _bottom = int.Parse(Console.ReadLine());
                    Thread.Sleep(100);
                    if (_bottom == 0)
                    {
                        throw new Exception("ERROR: You cannot divide by ZERO");
                    }
                    frac.SetBottom(_bottom); 
                    _var = false;
                } catch (FormatException)
                {
                    Console.WriteLine("ERROR: Pleas enter an int value."); 
                    Thread.Sleep(3000);
                    _var =  true;
                } catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}"); 
                    Thread.Sleep(3000);
                    _var = true;
                }
                }while(_var);
                break;
                
                case "3": 
                Console.Clear();
                string _fractionS = frac.GetFractionString();
                double _fractionD = frac.GetFraction();
                Console.WriteLine("Press 'enter' to leave.");
                Thread.Sleep(100);
                Console.WriteLine($"Fraction: {_fractionS}");
                Thread.Sleep(100);
                Console.WriteLine($"Decimal: {_fractionD}");
                Console.ReadLine();
                break; 
                
                case "4":
                loop = false;
                Console.WriteLine("Thank you for using my program ༼ つ ◕_◕ ༽つ");
                break;
                
                default:
                Console.WriteLine("Please enter a number between 1 and 4.");
                Thread.Sleep(3000);
                break; 
            }
        }
       
    }
}