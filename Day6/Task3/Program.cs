using Task3;
public delegate void DownloadProgressHandler(int percentage);

class Program
{
    static void Main()
    {
        FileDownloader downloader = new FileDownloader();
        ProgressBar bar = new ProgressBar();
        Logger logger = new Logger();
        
        downloader.DownloadProgress += bar.OnProgressChanged;
        downloader.DownloadProgress += logger.LogProgress;
        
        Console.WriteLine("Начало загрузки файла ");
        
        downloader.StartDownload();
        
        Console.WriteLine("Конец загрузки файла");
    }
}