namespace Task3
{
    public class FileDownloader
    {
        public event DownloadProgressHandler DownloadProgress;

        public void StartDownload()
        {
            for (int i = 0; i <= 100; i += 25)
            {
                Thread.Sleep(500);
                OnDownloadProgress(i);
            }
        }

        protected void OnDownloadProgress(int percentage)
        {
            DownloadProgress?.Invoke(percentage);
        }
    }
}