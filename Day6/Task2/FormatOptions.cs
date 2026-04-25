using System.Globalization;

namespace Task2
{
    public class FormatOptions
    {
        public string ShortFormat(DateTime date)
        {
            return date.ToString("dd.MM.yyyy");
        }

        public string LongFormat(DateTime date)
        {
            return date.ToString("dd MMMM yyyy 'года', dddd", new CultureInfo("ru-RU"));
        }
    }
}