class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        double B = double.Parse(Console.ReadLine());
        Console.Write("Введите M (количество шагов): ");
        int M = int.Parse(Console.ReadLine());

        double H = (B - A) / M;
        double x = A;

        Console.WriteLine("x\t\ty = x^2 - e^x");
        Console.WriteLine("-----------------------");

        for (int i = 0; i <= M; i++)
        {
            double y = x * x - Math.Exp(x);
            Console.WriteLine($"{x:F4}\t{y:F4}");
            x += H;
        }
    }
}