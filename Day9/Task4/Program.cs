using Task4;

class Program
{
    static void Main()
    {
        ConfigWatcher configWatcher = new ConfigWatcher();
        string path = "/home/admin/Документы/GitHub/PracticeCSharp/Day9/Task4";

        configWatcher.Start(path);

        Console.WriteLine($"Мониторинг .config файлов запущен в: {path}");
        Console.WriteLine("Нажмите любую клавишу для остановки...");
            
        Console.ReadKey(true);
        configWatcher.Stop();
    }
}