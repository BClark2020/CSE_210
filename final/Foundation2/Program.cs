using System;
using System.Runtime.InteropServices;

class Program
{
    private List<Order> _orders = new List<Order>();
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Menu();
        Console.WriteLine("Thank you for using my program (~^-^)~\n");
    }
    
    
    private void Menu()
    {
        while(true)
        {
            Console.Write("Select a number:\n1.) Make New Order\n2.) Display Orders\n3.) Quit");
            string _option = Console.ReadLine();
            
            switch(_option)
            {
                case "1":
                    Order _order =  new Order();
                    _order.MakeOrder();
                    _orders.Add(_order);
                break;
                
                case "2":
                    DisplayOrders();
                break;
                
                case "3":
                
                return;
                
                default:
                    Console.WriteLine("Please select an option 1, 2 or 3");
                break;
                
            }
          
        }
    }
    private void DisplayOrders()
    {
        foreach (Order _order in _orders)
        {
            _order.DisplayOrder();
             Console.WriteLine("\n");
        }
    }
    
    
}
