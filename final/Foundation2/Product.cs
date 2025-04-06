class Product
{
    private string _name = "COOKIES!!!!";
    private string _id = " ";
    private decimal _price = 0.00m;
    private int _qty = 1;
    
    public Product(string _item_name, string _item_id, decimal _item_price, int _item_qty)
    {
        _name = _item_name;
        _id = _item_id;
        _price = _item_price;
        _qty = _item_qty;
    }

    public string GetItemName()
    {
        return _name;
    }
    
    public string GetProductID()
    {
        return _id;
    }
    public decimal GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _qty;
    }
}