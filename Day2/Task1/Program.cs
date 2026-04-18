class Program
{
    static void Main()
    {
        double[] numbers = { 1.5, -2.3, 4.0, -0.5, -10.2, 7.8 };

        int count = 0;
        foreach (double num in numbers)
        {
            if (num < 0)
            {
                count++;
            }
        }

        int countLinq = numbers.Count(n => n < 0);

        Console.WriteLine($"Количество отрицательных элементов: {count}");
    }
}