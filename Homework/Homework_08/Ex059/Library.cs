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

    public static void GetRowMinValue(int[,] array)
    {
        int index = 0, minSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            Console.WriteLine($"Сумма элементов строки № {i + 1} = {sum}");
            if (i == 0)
            {
                minSum = sum;
            }
            else if (sum < minSum)
            {
                minSum = sum;
                index = i;
            }
        }
        string line = string.Empty;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            line += array[index, j] + " ";
        }
        Console.WriteLine();
        Console.WriteLine($"Строка № {index + 1} содержит минимальную сумму элементов.");
        Console.WriteLine();
    }
}
