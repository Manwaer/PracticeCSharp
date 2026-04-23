class Program
{
    static void InvDigits(ref int K)
    {
        int reversed = 0;

        while (K > 0)
        {
            int digit = K % 10;
            reversed = reversed * 10 + digit;
            K /= 10;
        }

        K = reversed;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        InvDigits(ref a);
        InvDigits(ref b);
        InvDigits(ref c);
        InvDigits(ref d);
        InvDigits(ref e);

        Console.WriteLine($"{a} {b} {c} {d} {e}");
    }
}