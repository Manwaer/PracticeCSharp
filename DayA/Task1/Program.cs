class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите стоимость яблок -> ");
        double cost = double.Parse(Console.ReadLine());
        Console.Write("Введите вес яблок -> ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write($"Стоимость яблок -> {Math.Round(cost * weight, 2)}");
    }
}