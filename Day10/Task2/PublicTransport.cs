namespace Task2
{
    public class PublicTransport : ITransportStrategy
    {
        public void Move()
        {
            Console.WriteLine("Поездка на общественном транспорте: бюджетно и по расписанию.");
        }
    }
}