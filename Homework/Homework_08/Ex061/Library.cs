public static class Library
{
    public static int[,] FillArray(int[,] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(1, 9);
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

    public static int[,] MultArray(int[,] arrayA, int[,] arrayB)
    {
        int[,] mult = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

        for (int i = 0; i < arrayA.GetLength(0); ++i)
        {
            for (int j = 0; j < arrayB.GetLength(0); ++j)
            {
                for (int e = 0; e < arrayB.GetLength(1); ++e)
                {
                    mult[i, e] += arrayA[i, j] * arrayB[j, e];
                }
            }
        }
        return mult;
    }
}