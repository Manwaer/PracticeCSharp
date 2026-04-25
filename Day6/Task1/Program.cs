using Task1;

delegate int[] SortMethod(int[] arr);
class Program
{
    static void Main(string[] args)
    {
        SortMethod sorts;
        
        BubbleSort bubbleSort = new BubbleSort();
        QuickSort quickSort = new QuickSort();
        
        sorts = bubbleSort.Sort;
        sorts += quickSort.Sort;
        
        int[] array = new int[10] {2, 5, 1, 9, 3, 4, 7, 6, 0, 1};
        sorts(array);
        
        Console.WriteLine(string.Join(", ", array));
    }
}
