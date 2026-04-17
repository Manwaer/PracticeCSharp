class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд, прошедших с начала суток: ");
        int n = int.Parse(Console.ReadLine());
        int hours = n / 3600;
        Console.WriteLine($"С начала суток прошло полных часов: {hours}");
    }
}