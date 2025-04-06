using System;
using System.Runtime.InteropServices;

class Program
{
    List<Order> _orders = new List<Order>();
    static void Main(string[] args)
    {
        bool _loop = true;
        while(_loop)
        {
            Console.Write("Select a number:\n1.) Make New Order\n2.) Display Orders\n3.) Quit");
            string _option = Console.ReadLine();
            
            switch(_option)
            {
                case "1":
            
                break;
                
                case "2":
                
                break;
                
                case "3":
                    _loop = false;
                break;
                
                default:
                    Console.WriteLine("Please select an option 1, 2 or 3");
                break;
                
            }
            
        }
    }
    
    
}
