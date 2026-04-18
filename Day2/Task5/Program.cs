class Program
{
    static void Main()
    {
        int[][] array1 =
        {
            new int[] { 1, 2 },
            new int[] { 3, 4, 5 }
        };

        int[][] array2 =
        {
            new int[] { 6 },
            new int[] { 7, 8 }
        };

        int[][] result = new int[array1.Length + array2.Length][];

        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i];
        }

        for (int i = 0; i < array2.Length; i++)
        {
            result[array1.Length + i] = array2[i];
        }

        foreach (int[] row in result)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
