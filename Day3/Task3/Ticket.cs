namespace Task3;

public abstract class Ticket
{
    public string EventName { get; set; }
    public double Price { get; set; }
    public int SeatNumber { get; set; }

    protected Ticket(string eventName, double price, int seatNumber)
    {
        EventName = eventName;
        Price = price;
        SeatNumber = seatNumber;
    }
}

