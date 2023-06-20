internal class Program
{
    private static int[] SwapSort(int[] arr)
    {
        var sortedArr = new int[arr.Length];
        sortedArr = arr;

        for (int i = 0; i < arr.Length -1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[i])
                {
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
        return sortedArr;
    }
    private static void Main(string[] args)
    {
        var arr = new int[] { 1, 5, 3, 2, 4, 3, 2};
        
        foreach (var item in SwapSort(arr))
        {
            Console.Write(item + " ");
        }
    }
}