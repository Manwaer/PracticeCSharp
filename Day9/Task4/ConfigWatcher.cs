namespace Task4
{
    public class ConfigWatcher
    {
        private FileSystemWatcher _watcher;

        public void Start(string path)
        {
            _watcher = new FileSystemWatcher(path);

            _watcher.Filter = "*.config";

            _watcher.NotifyFilter = NotifyFilters.FileName 

                                    | NotifyFilters.LastWrite 
                                    | NotifyFilters.CreationTime;

            _watcher.Changed += OnChanged;
            _watcher.Created += OnCreated;
            _watcher.Deleted += OnDeleted;
            _watcher.Renamed += OnRenamed;

            _watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Конфигурация изменена! Файл: {e.Name}");
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Создан новый конфигурационный файл: {e.Name}");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Конфигурационный файл удален: {e.Name}");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Конфигурационный файл переименован из {e.OldName} в {e.Name}");
        }

        public void Stop()
        {
            _watcher.EnableRaisingEvents = false;
            _watcher.Dispose();
        }
    }
}