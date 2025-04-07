using System.Runtime.InteropServices.Marshalling;

class Order
{
    private List<Product> _products = new List<Product>();
    private string _packing_label = " ";
    private string _shipping_label = " ";
    private Customer _customer;
    bool USA = true;
    
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
        string _name = Console.ReadLine();
        
        Console.Write("Customer Street Address: ");
        string _street = Console.ReadLine();
        
        Console.Write("City: ");
        string _city = Console.ReadLine();
        
        Console.Write("State/Province: ");
        string _state = Console.ReadLine();
        
        Console.Write("Country: ");
        string _country = Console.ReadLine();
        
        _customer = new Customer(_name, _street, _city, _state, _country);  
    }
    
    private void AddProducts()
    {
        bool _add = true;
        while(_add)
        {
            Console.Clear();
            Console.WriteLine("-------Enter Your Products-------");
            Console.WriteLine("Enter \" \" to leave.");
            
            Console.Write("Item Name: ");
            string _name = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(_name))
            {
                return;
            }
            
            Console.Write("Item ID: ");
            string _id = Console.ReadLine();
            
            decimal _price = 0.00m; 
            bool _loop = false;
            do
            {
                try
                {
                    Console.Write("Item Price: ");
                    _price = decimal.Parse(Console.ReadLine());
                    _loop = false;      
                }catch (FormatException)
                { 
                    Console.WriteLine("\nERROR: enter a value with two decimal points (example: 25.00, 14.99).\n");
                    Thread.Sleep(2000);
                    _loop = true;    
                }    
            }while(_loop);
            
            int _qty =0;
            do
            {
                try
                {
                    Console.Write("Item Quantity: ");
                    _qty = int.Parse(Console.ReadLine());
                    _loop = false;      
                }catch (FormatException)
                { 
                    Console.WriteLine("\nERROR: enter an integer value (example: 1 , 45, 27).\n");
                    Thread.Sleep(2000);
                    _loop = true;    
                }    
            }while(_loop);
            
            Product _product = new Product(_name, _id, _price, _qty);
            _products.Add(_product);
        }
  
    }
    
    private void MakePakingLabel()
    {
        decimal _total = 0.00m;
        _packing_label = "-------Packing Label-------";
        _packing_label += "\nItem Name: Item ID";
        foreach (Product _product in _products)
        {
            string _item = _product.GetItemName();
            string _item_id = _product.GetProductID();
            
            decimal _price = _product.GetPrice();
            int _qty = _product.GetQuantity();
            
            _total += _price * _qty;
            
            string _line = $"\n{_item}: {_item_id}";
            _packing_label += _line;
        }
        decimal _tax = _total * 0.06m;
        Console.WriteLine("---Pricing---");
        _packing_label += $"\nBefore Tax: ${_total}";
        _packing_label += $"\nTax: ${_tax:0.00}";
        
        int _shipping;
        if (_customer.IsUSA())
        {
            _shipping = 5;
        } else
        {
            _shipping = 35;
        }
        
        _packing_label += $"\nShipping: ${_shipping - 0.01m:0.00}";
        _packing_label += $"\nTotal: ${(_total + _tax + _shipping):0.00}";
    }
    
    private void MakeShippingLabel()
    {
        _shipping_label = "-------Shipping Label-------";
        _shipping_label +=$"\n{_customer.GetCustomerName()}";
        _shipping_label += $"\n{_customer.GetAddress()}"; 
    }
    

        public void DisplayOrder( bool _display_all = false)
    {
        Console.Clear();
        Console.WriteLine(_shipping_label);
        Console.WriteLine(_packing_label);
        if (_display_all == false)
        {
            Console.WriteLine("Press enter to leave.");
            string _wait =  Console.ReadLine();
        } 
    }
}