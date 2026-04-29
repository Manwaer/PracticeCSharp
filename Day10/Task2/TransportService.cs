namespace Task2
{
    public class TransportService
    {
        private ITransportStrategy _strategy;

        public void SetStrategy(ITransportStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteTrip()
        {
            _strategy.Move();
        }
    }
}