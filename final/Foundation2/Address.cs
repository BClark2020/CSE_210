class Address 
{
    private string _street = " ";
    private string _city = " ";
    private string _state_prov = " ";
    private string _country = " ";
    
    public Address(string _street_addrs, string _city_addrs, string _stateprov_addrs, string _country_addrs)
    {
        _street = _street_addrs;
        _city = _city_addrs;
        _state_prov = _stateprov_addrs;
        _country = _country_addrs;
    }
    
    public string GetAddress()
    {
        string _address = $" Street Address:{_street}, {_city}\nState/Province: {_state_prov}\nCountry: {_country}";
        return _address;
    }
    
    public bool IsUSA()
    {
        if (_country != "USA")
        {
            return false;
        } else
        {
            return true;
        }
    }
}