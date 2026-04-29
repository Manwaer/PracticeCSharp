using Task1;

class Program
{
    static void Main()
    {
        TaskQueueManager manager = TaskQueueManager.GetInstance();

        manager.AddTask(() => Console.WriteLine("Задача 1: Обработка данных..."));
        manager.AddTask(() => Console.WriteLine("Задача 2: Генерация отчета..."));
        manager.AddTask(() => Console.WriteLine("Задача 3: Отправка уведомления..."));

        Console.WriteLine("Начало выполнения задач из единой очереди:");
        manager.ExecuteTasks();
    }
}