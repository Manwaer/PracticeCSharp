class Program
{
    static void Main()
    {
        Console.WriteLine("Дюймы\tСантиметры");
        Console.WriteLine("-----------------");

        for (int inches = 2; inches <= 24; inches += 2)
        {
            double cm = inches * 2.54;
            Console.WriteLine($"{inches}\t{cm:F2}");
        }
    }
}