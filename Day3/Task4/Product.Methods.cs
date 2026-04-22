namespace Task4;

public partial class Product
{
    public bool IsOutOfStock()
    {
        return Stock == 0;
    }

    public void AddStock(int amount)
    {
        Stock += amount;
    }

    public void RemoveStock(int amount)
    {
        if (amount <= Stock)
            Stock -= amount;
    }
}