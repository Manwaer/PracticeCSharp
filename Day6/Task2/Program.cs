using Task2;
public delegate string DateFormatter(DateTime date);

class Program 
{
    static void Main()
    {
        DateProcessor processor = new DateProcessor();
        FormatOptions options = new FormatOptions();
        DateTime now = DateTime.Now;
        Console.WriteLine("Работа с методами обратного вызова:");
        
        processor.FormatDate(now, options.ShortFormat);
        
        processor.FormatDate(now, options.LongFormat);
    }
}