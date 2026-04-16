class Program
{
    static void Main()
    {
        Console.Write("Введите число b: ");
        double b = double.Parse(Console.ReadLine());
        double sqrt = Math.Sqrt(b * b - 4);
        double z1 = Math.Sqrt(2 * b + 2 * sqrt) / (sqrt + b + 2);
        double z2 = 1.0 / Math.Sqrt(b + 2);
        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
    }
}