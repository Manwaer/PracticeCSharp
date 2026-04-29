namespace Task3
{
    public class OrderSystem
    {
        public string PlaceOrder(string dish) => $"Заказ на блюдо '{dish}' успешно оформлен.";
        public string CancelOrder(string dish) => $"Заказ на блюдо '{dish}' был отменен.";
    }
}