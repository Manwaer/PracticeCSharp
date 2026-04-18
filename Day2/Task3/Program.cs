class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, -2, 3 },
            { 4, 5, -6 },
            { -7, 8, 9 }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int sumEven = 0;
        foreach (int val in matrix)
        {
            if (val % 2 == 0)
            {
                sumEven += val;
            }
        }

        Console.WriteLine($"Сумма чётных: {sumEven}");

        for (int j = 0; j < cols; j++)
        {
            int positiveCount = 0;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveCount++;
                }
            }
            Console.WriteLine($"Столбец {j}: положительных элементов {positiveCount}");
        }
    }
}
