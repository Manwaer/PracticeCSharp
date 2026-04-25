namespace Task3
{
    public class ProgressBar
    {
        public void OnProgressChanged(int percent)
        {
            Console.WriteLine($"[Индикатор]: [{new string('#', percent / 10)}{new string('-', 10 - (percent / 10))}] {percent}%");
        }
    }
}