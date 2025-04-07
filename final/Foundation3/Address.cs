class Address
{
    private string _street = " ";
    private string _city = " ";
    private string _stateProv = " ";
    private string _country = " ";

    public Address(string streetAddrs, string cityAddrs, string stateProvAddrs, string countryAddrs)
    {
        _street = streetAddrs;
        _city = cityAddrs;
        _stateProv = stateProvAddrs;
        _country = countryAddrs;
    }

    public string GetAddress()
    {
        string address = $" Street Address:{_street}, {_city}\nState/Province: {_stateProv}\nCountry: {_country}";
        return address;
    }

}