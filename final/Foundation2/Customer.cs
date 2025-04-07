class Customer
{
    private string _name = " ";
    private Address _addrs;

    public Customer(string customerName, string street, string city, string stateProv, string country)
    {
        _name = customerName;
        _addrs = new Address(street, city, stateProv, country);
    }

    public string GetCustomerName()
    {
        return _name;
    }
    public string GetAddress()
    {
        string address = _addrs.GetAddress();
        return address;
    }
    public bool IsUSA()
    {
        bool usa = _addrs.IsUSA();
        return usa;
    }
}