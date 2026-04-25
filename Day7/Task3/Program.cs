using Task3;

class Program
{
    static void Main()
    {
        OrderManager manager = new OrderManager();

        try
        {
            manager.PlaceOrder(50);
            manager.PlaceOrder(150);
        }
        catch (OrderLimitExceededException ex)
        {
            Console.WriteLine($"Ошибка оформления заказа: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
        }
    }
}