namespace Task3
{
    public class PlaceOrderCommand : ICommand
    {
        private OrderSystem _orderSystem;
        private string _dish;

        public PlaceOrderCommand(OrderSystem orderSystem, string dish)
        {
            _orderSystem = orderSystem;
            _dish = dish;
        }

        public string Execute() => _orderSystem.PlaceOrder(_dish);
    }
}