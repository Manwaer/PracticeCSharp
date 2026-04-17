class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 1000;
        int secondDigit = (number / 100) % 10;

        if (firstDigit > secondDigit)
        {
            Console.WriteLine("Первая цифра больше");
        }
        else if (secondDigit > firstDigit)
        {
            Console.WriteLine("Вторая цифра больше");
        }
        else
        {
            Console.WriteLine("Цифры равны");
        }
    }
}