class Program
{
    static void SortArray(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    static void Main(string[] args)
    {

        int[] numbers = { 5, 2, 9, 1, 3 };

        SortArray(numbers);

        foreach (var n in numbers)
        {
            Console.Write(n + " ");
        }
    }
}