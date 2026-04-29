namespace Task3
{
    public class CancelOrderCommand : ICommand
    {
        private OrderSystem _orderSystem;
        private string _dish;

        public CancelOrderCommand(OrderSystem orderSystem, string dish)
        {
            _orderSystem = orderSystem;
            _dish = dish;
        }

        public string Execute() => _orderSystem.CancelOrder(_dish);
    }
}