using Task2;
class  Program
{
    static void Main(string[] args)
    {
        MathOperations mathOperations = new MathOperations();
        Console.Write($"Сумма: {mathOperations.Sum(2.1, 3.2):F2}");
    }
}