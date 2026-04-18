class Program
{
    static void Main()
    {
        string encrypted = "Фхнжйч";
        int shift = 5;

        Console.WriteLine(DecryptCaesar(encrypted, shift));
    }

    static string DecryptCaesar(string text, int shift)
    {
        string lower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string upper = lower.ToUpper();

        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (lower.Contains(c))
            {
                int index = lower.IndexOf(c);
                int newIndex = (index - shift + lower.Length) % lower.Length;
                result[i] = lower[newIndex];
            }
            else if (upper.Contains(c))
            {
                int index = upper.IndexOf(c);
                int newIndex = (index - shift + upper.Length) % upper.Length;
                result[i] = upper[newIndex];
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }
}