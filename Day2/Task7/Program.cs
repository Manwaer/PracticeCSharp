class Program
{
    static void Main()
    {
        string text = "Че типа как белоснежка";
        string prefix = "Че типа";

        bool startsWith = text.StartsWith(prefix);

        Console.WriteLine(startsWith);
    }
}
