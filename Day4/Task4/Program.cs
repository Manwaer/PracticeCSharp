static class ListExtensions
{
    public static double Median(this List<int> list)
    {
        if (list == null || list.Count == 0)
            throw new InvalidOperationException();

        var sorted = list.OrderBy(x => x).ToList();
        int n = sorted.Count;

        if (n % 2 == 1)
            return sorted[n / 2];

        return (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
    }
}

class Program
{
    static void Main()
    {
        var list = new List<int> { 1, 3, 2, 4 };
        Console.WriteLine(list.Median());
    }
}