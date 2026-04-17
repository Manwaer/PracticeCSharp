class Program
{
    static void Main()
    {
        Console.Write("Введите A (A < B): ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = A; i <= B; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма чисел от {A} до {B}: {sum}");
    }
}