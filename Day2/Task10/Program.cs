using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Звоните +375291234567 или +375331112233";

        string pattern = @"\+375\d{9}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}