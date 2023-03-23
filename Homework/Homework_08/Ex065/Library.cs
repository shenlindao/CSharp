public static class Library
{
    public static int[,] FillArray(int[,] array)
    {
        int i = 0;
        int j = 0;

        for (int tmp = 1; tmp <= array.GetLength(0) * array.GetLength(1); tmp++)
        {
            array[i, j] = tmp;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= array.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > array.GetLength(1) - 1)
                j--;
            else
                i--;
        }
        return array;
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}