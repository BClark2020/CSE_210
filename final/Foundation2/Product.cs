class Product
{
    private string _name = "COOKIES!!!!";
    private string _id = " ";
    private decimal _price = 0.00m;
    private int _qty = 1;

    public Product(string itemName, string itemId, decimal itemPrice, int itemQty)
    {
        _name = itemName;
        _id = itemId;
        _price = itemPrice;
        _qty = itemQty;
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