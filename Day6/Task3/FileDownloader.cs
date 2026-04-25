namespace Task3
{
    public class FileDownloader
    {
        public event DownloadProgressHandler DownloadProgress;

        public void StartDownload()
        {
            Console.WriteLine("Начало загрузки файла...");
            for (int i = 0; i <= 100; i += 25)
            {
                Thread.Sleep(500);
                OnDownloadProgress(i);
            }
            Console.WriteLine("Загрузка завершена.");
        }

        protected virtual void OnDownloadProgress(int percentage)
        {
            DownloadProgress?.Invoke(percentage);
        }
    }
}