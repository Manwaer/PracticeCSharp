namespace Task3;

public sealed class ConcertTicket : Ticket
{
    public ConcertTicket(string eventName, double price, int seatNumber)
        : base(eventName, price, seatNumber)
    {
    }
}