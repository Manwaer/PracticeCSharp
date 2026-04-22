namespace Task3;

using System.Linq;

public class TicketOffice
{
    public Ticket[] Tickets { get; set; }

    public TicketOffice(Ticket[] tickets)
    {
        Tickets = tickets;
    }

    public double GetTotalRevenue()
    {
        return Tickets.Sum(t => t.Price);
    }

    public Ticket GetMostExpensiveTicket()
    {
        return Tickets.OrderByDescending(t => t.Price).FirstOrDefault();
    }
}