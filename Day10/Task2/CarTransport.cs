namespace Task2
{
    public class CarTransport : ITransportStrategy
    {
        public void Move()
        {
            Console.WriteLine("Поездка на автомобиле: комфортно, но возможны пробки.");
        }
    }
}