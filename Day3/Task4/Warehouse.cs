namespace Task4;
using System.Linq;

public class Warehouse
{
    public Product[] Products { get; set; }

    public Warehouse(Product[] products)
    {
        Products = products;
    }

    public Product[] GetOutOfStockProducts()
    {
        return Products.Where(p => p.Stock == 0).ToArray();
    }

    public Product GetMostExpensiveProduct()
    {
        return Products.OrderByDescending(p => p.Price).FirstOrDefault();
    }
}