namespace Task3;

public sealed class TheaterTicket : Ticket
{
    public TheaterTicket(string eventName, double price, int seatNumber)
        : base(eventName, price, seatNumber)
    {
    }
}