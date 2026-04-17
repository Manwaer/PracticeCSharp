class Program
{
    static void Main()
    {
        Console.Write("Введите первое целое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите третье целое число: ");
        int c = int.Parse(Console.ReadLine());

        bool result = (a == b) || (a == c) || (b == c);
        Console.WriteLine(result);
    }
}