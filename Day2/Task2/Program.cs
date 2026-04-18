class Program
{
    static void Main()
    {
        int[] a = new int[100];
        Random rnd = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(-100, 101);
        }

        int max = a.Max();

        int[] result = new int[100];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = (a[i] == max) ? 1 : 0;
        }

        foreach (int val in result)
        {
            Console.Write(val + " ");
        }
    }
}
