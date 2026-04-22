using Task4;
class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product { Name = "Молоко", Category = "Еда", Price = 1.5, Stock = 10 },
            new Product { Name = "Bread", Category = "Еда", Price = 1.0, Stock = 0 },
            new Product { Name = "Ноутбук", Category = "Электроника", Price = 500, Stock = 5 }
        };

        Warehouse warehouse = new Warehouse(products);

        var outOfStock = warehouse.GetOutOfStockProducts();
        Console.WriteLine("Нет в наличии:");
        foreach (var p in outOfStock)
            Console.WriteLine(p.Name);

        var expensive = warehouse.GetMostExpensiveProduct();
        Console.WriteLine($"Самый дорогой: {expensive.Name}");
    }
}