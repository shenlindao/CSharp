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

    public static void Arithmetic(int[,] array)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            Console.WriteLine($"Среднее арифметическое элементов в столбце № {j + 1} = {sum / array.GetLength(0)}");
        }
    }
}
