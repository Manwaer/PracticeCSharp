class Program
{
    static void Main()
    {
        string input = "ПрИВЕТ";

        bool isAllUpper = input.All(char.IsUpper);
        bool isAllLower = input.All(char.IsLower);

        if (isAllUpper || isAllLower)
        {
            Console.WriteLine("Строка содержит буквы только одного регистра");
        }
        else
        {
            Console.WriteLine("Строка содержит буквы разных регистров или другие символы");
        }
    }
}
