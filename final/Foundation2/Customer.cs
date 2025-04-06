class Customer
{
    private string _name = " ";
    private Address _addrs; 
    
    public Customer(string _customer_name, string _street, string _city, string _state_prov, string _country)
    {
        _name = _customer_name;
        _addrs = new Address(_street, _city, _state_prov, _country);
    }
    
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetAddress()
    {
        string _address =  _addrs.GetAddress();
        return _address;
    }
    public bool IsUSA()
    {
        bool USA = _addrs.IsUSA();
        return USA;
    }
}