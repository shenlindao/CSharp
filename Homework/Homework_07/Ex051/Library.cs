public static class Library
{
    public static string? GetValue(string text)
    {
        Console.Write(text);
        string? value = Console.ReadLine();
        if (value == String.Empty) value = null;
        return value;
    }

    public static (int M, int N) SetNumbers(int M, int N)
    {
        string err = "Значение не может быть пустым!";
        string? valueM = GetValue("Введите число M: ");
        if (valueM == null)
        {
            Console.WriteLine(err);
        }
        else
        {
            M = Convert.ToInt32(valueM);

            string? valueN = GetValue("Введите число N: ");
            if (valueN == null)
            {
                Console.WriteLine(err);
            }
            N = Convert.ToInt32(valueN);
        }
        return (M, N);
    }

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
}