using System.Runtime.InteropServices.Marshalling;

class Order
{
    private List<Product> _products = new List<Product>();
    private string _packingLabel = " ";
    private string _shippingLabel = " ";
    private Customer _customer;
    bool _usa = true;

    public void MakeOrder()
    {
        GetCustomer();
        AddProducts();
        MakePakingLabel();
        MakeShippingLabel();
        DisplayOrder();
    }

    private void GetCustomer()
    {
        Console.Clear();
        Console.WriteLine("-------Customer Information-------");
        Console.Write("Customer name: ");
        string name = Console.ReadLine();

        Console.Write("Customer Street Address: ");
        string street = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State/Province: ");
        string state = Console.ReadLine();

        Console.Write("Country: ");
        string country = Console.ReadLine();

        _customer = new Customer(name, street, city, state, country);
    }

    private void AddProducts()
    {
        bool add = true;
        while (add)
        {
            Console.Clear();
            Console.WriteLine("-------Enter Your Products-------");
            Console.WriteLine("Enter \" \" to leave.");

            Console.Write("Item Name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }

            Console.Write("Item ID: ");
            string id = Console.ReadLine();

            decimal price = 0.00m;
            bool loop = false;
            do
            {
                try
                {
                    Console.Write("Item Price: ");
                    price = decimal.Parse(Console.ReadLine());
                    loop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nERROR: enter a value with two decimal points (example: 25.00, 14.99).\n");
                    Thread.Sleep(2000);
                    loop = true;
                }
            } while (loop);

            int qty = 0;
            do
            {
                try
                {
                    Console.Write("Item Quantity: ");
                    qty = int.Parse(Console.ReadLine());
                    loop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nERROR: enter an integer value (example: 1 , 45, 27).\n");
                    Thread.Sleep(2000);
                    loop = true;
                }
            } while (loop);

            Product product = new Product(name, id, price, qty);
            _products.Add(product);
        }

    }

    private void MakePakingLabel()
    {
        decimal total = 0.00m;
        _packingLabel = "-------Packing Label-------";
        _packingLabel += "\nItem Name: Item ID";
        foreach (Product product in _products)
        {
            string item = product.GetItemName();
            string itemId = product.GetProductID();

            decimal price = product.GetPrice();
            int qty = product.GetQuantity();

            total += price * qty;

            string _line = $"\n{item}: {itemId}";
            _packingLabel += _line;
        }
        decimal tax = total * 0.06m;
        Console.WriteLine("---Pricing---");
        _packingLabel += $"\nBefore Tax: ${total}";
        _packingLabel += $"\nTax: ${tax:0.00}";

        int shipping;
        if (_customer.IsUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        _packingLabel += $"\nShipping: ${shipping - 0.01m:0.00}";
        _packingLabel += $"\nTotal: ${(total + tax + shipping):0.00}";
    }

    private void MakeShippingLabel()
    {
        _shippingLabel = "-------Shipping Label-------";
        _shippingLabel += $"\n{_customer.GetCustomerName()}";
        _shippingLabel += $"\n{_customer.GetAddress()}";
    }


    public void DisplayOrder(bool displayAll = false)
    {
        Console.Clear();
        Console.WriteLine(_shippingLabel);
        Console.WriteLine(_packingLabel);
        if (displayAll == false)
        {
            Console.WriteLine("Press enter to leave.");
            string wait = Console.ReadLine();
        }
    }
}