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
        while (true)
        {
            Console.Clear();
            Console.Write("Select a number:\n1.) Make New Order\n2.) Display Orders\n3.) Quit\nOption: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Order order = new Order();
                    order.MakeOrder();
                    _orders.Add(order);
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
        Console.Clear();
        foreach (Order order in _orders)
        {
            order.DisplayOrder(true);
            Console.WriteLine("\n");
        }
        Console.WriteLine("Press enter to leave.");
        string wait = Console.ReadLine();
    }
}
