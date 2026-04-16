class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int first = number / 100;
        int second = (number / 10) % 10;
        int third = number % 10;
        int result = second * 100 + first * 10 + third;
        Console.WriteLine(result);
    }
}