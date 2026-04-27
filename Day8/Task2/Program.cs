using Task2;

class Program
{
    static void Main()
    {
        SortedListManager<int, string> manager = new SortedListManager<int, string>();

        manager.AddItem(10, "Десять");
        manager.AddItem(5, "Пять");
        manager.AddItem(20, "Двадцать");
        manager.AddItem(1, "Один");

        Console.WriteLine("Содержимое (автоматически отсортировано по ключу):");
        manager.DisplayList();

        Console.WriteLine("\nПоиск ключа 5:");
        manager.SearchAndPrint(5);

        manager.RemoveItem(10);
        Console.WriteLine("\nПосле удаления ключа 10:");
        manager.DisplayList();
    }
}