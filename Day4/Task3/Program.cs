class Program
{
    static int SumOfDigits(int n)
    {
        n = Math.Abs(n);
        if (n < 10)
            return n;
        return n % 10 + SumOfDigits(n / 10);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(SumOfDigits(n));
    }
}