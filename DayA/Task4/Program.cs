class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine($"({a:F2}+{b:F2})+{c:F2}={a:F2}+({b:F2}+{c:F2})");
    }
}