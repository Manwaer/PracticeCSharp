namespace Task3
{
    public class Logger
    {
        public void LogProgress(int percent)
        {
            Console.WriteLine($"[Логгер]: {DateTime.Now:HH:mm:ss} - Загружено {percent}%");
        }
    }
}