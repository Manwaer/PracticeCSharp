namespace Task2
{
    public class DateProcessor
    {
        public void FormatDate(DateTime date, DateFormatter formatter)
        {
            string result = formatter(date);
            Console.WriteLine($"Результат форматирования: {result}");
        }
    }
}