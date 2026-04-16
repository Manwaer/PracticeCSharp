class Program
{
    static void Main()
    {
        Console.Write("Введите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine());
        string revNum = number.ToString();
        revNum = new string(revNum.Reverse().ToArray());
        Console.Write($"Перевёрнутое число {revNum}");
    }
}