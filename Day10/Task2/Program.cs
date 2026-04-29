using Task2;

class Program
{
    static void Main()
    {
        TransportService service = new TransportService();

        service.SetStrategy(new CarTransport());
        service.ExecuteTrip();

        service.SetStrategy(new BikeTransport());
        service.ExecuteTrip();

        service.SetStrategy(new PublicTransport());
        service.ExecuteTrip();
    }
}