namespace Task3
{
    public class OrderManager
    {
        public void PlaceOrder(int itemCount)
        {
            if (itemCount > 100)
            {
                throw new OrderLimitExceededException($"Превышен лимит заказа: {itemCount} товаров. Максимум разрешено 100.");
            }
            Console.WriteLine($"Заказ на {itemCount} товаров успешно размещен.");
        }
    }
}