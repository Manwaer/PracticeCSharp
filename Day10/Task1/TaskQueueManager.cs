namespace Task1
{
    public class TaskQueueManager
    {
        private static TaskQueueManager _instance;
        private Queue<Action> _tasks;

        private TaskQueueManager()
        {
            _tasks = new Queue<Action>();
        }

        public static TaskQueueManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TaskQueueManager();
            }
            return _instance;
        }

        public void AddTask(Action task)
        {
            _tasks.Enqueue(task);
        }

        public void ExecuteTasks()
        {
            while (_tasks.Count > 0)
            {
                Action task = _tasks.Dequeue();
                task.Invoke();
            }
        }
    }
}
