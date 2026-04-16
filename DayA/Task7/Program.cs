using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сторону a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        double b = double.Parse(Console.ReadLine());
        double P = 2 * (a + b);
        double S = a * b;
        double d = Math.Sqrt(a * a + b * b);
        Console.WriteLine($"P = {P}");
        Console.WriteLine($"S = {S}");
        Console.WriteLine($"d = {d}");
    }
}