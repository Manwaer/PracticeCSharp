class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        double y;

        if (x < 0)
        {
            y = Math.Sqrt(2 * x * x + Math.Sin(x) + 1);
        }
        else if (x == 0 || x == 1)
        {
            y = 2 * x + Math.Exp(x);
        }
        else
        {
            y = 0;
            Console.WriteLine("Функция не определена для данного x");
        }

        Console.WriteLine($"y = {y}");
    }
}