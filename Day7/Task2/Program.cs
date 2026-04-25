using Task2;

class Program
{
    static void Main()
    {
        CalculationManager manager = new CalculationManager();

        try
        {
            manager.PerformCalculation(10, 0);
        }
        catch (MathException ex)
        {
            Console.WriteLine($"Основное сообщение: {ex.Message}");
                
            if (ex.InnerException != null)
            {
                Console.WriteLine($"Внутреннее исключение: {ex.InnerException.GetType().Name}");
                Console.WriteLine($"Сообщение оригинала: {ex.InnerException.Message}");
            }

            Console.WriteLine("\nСтек вызовов:");
            Console.WriteLine(ex.StackTrace);
        }
    }
}