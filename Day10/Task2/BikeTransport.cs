namespace Task2
{
    public class BikeTransport : ITransportStrategy
    {
        public void Move()
        {
            Console.WriteLine("Поездка на велосипеде: экологично и полезно для здоровья.");
        }
    }
}