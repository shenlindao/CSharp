public static class Library
{
    public static int[,] FillArray(int[,] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(10, 99);
            }
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

    public static void SortingOrderDecreasing(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int e = 0; e < array.GetLength(1) - 1; e++)
                {
                    if (array[i, e] < array[i, e + 1])
                    {
                        int n = array[i, e + 1];
                        array[i, e + 1] = array[i, e];
                        array[i, e] = n;
                    }
                }
            }
        }
    }
}
