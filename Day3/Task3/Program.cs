using Task3;
class Program
{
    static void Main()
    {
        Ticket[] tickets = new Ticket[]
        {
            new ConcertTicket("Rock Concert", 50, 1),
            new TheaterTicket("Hamlet", 70, 10),
            new ConcertTicket("Jazz Night", 40, 5)
        };

        TicketOffice office = new TicketOffice(tickets);

        Console.WriteLine($"Общая выручка: {office.GetTotalRevenue()}");

        var expensive = office.GetMostExpensiveTicket();
        Console.WriteLine($"Самый дорогой билет: {expensive.EventName}, цена: {expensive.Price}");
    }
}