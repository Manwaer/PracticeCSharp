using Task3;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 5, 8, 12, 15, 20, 23, 30 };
            
        SimpleFilter<int> intFilter = new SimpleFilter<int>();
        FilterManager<int> manager = new FilterManager<int>(intFilter);

        Console.WriteLine("Фильтрация чисел больше 15:");
        manager.PrintFiltered(numbers, n => n > 15);

        Console.WriteLine("\nФильтрация четных чисел:");
        manager.PrintFiltered(numbers, n => n % 2 == 0);

        List<string> words = new List<string> { "Яблоко", "Банан", "Ананас", "Груша" };
        FilterManager<string> stringManager = new FilterManager<string>(new SimpleFilter<string>());

        Console.WriteLine("\nСлова на букву 'А':");
        stringManager.PrintFiltered(words, w => w.StartsWith("А"));
    }
}
