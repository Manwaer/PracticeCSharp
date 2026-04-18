using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Привет");
        sb.Append(" мир");

        Console.WriteLine(sb.ToString());

        sb.Clear();

        Console.WriteLine("После очистки: " + sb.ToString());
    }
}