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
        Console.WriteLine();
        Console.WriteLine("Ваш исходный массив:");
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    public static int GetLargestNumber(int[,] array)
    {
        int m = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) if (array[i, j] > m) m = array[i, j];
        }
        return m;
    }

    public static void Frequency(int[,] array, int m)
    {
        int[] c = new int[m + 1];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) c[array[i, j]]++;
        }
        Console.WriteLine();
        for (int i = 0; i < c.Length; i++)
        {
            string raz = String.Empty;
            raz = (c[i] == 1 || c[i] == 5 || c[i] == 6 || c[i] == 7 || c[i] == 8 || c[i] == 9) ? "раз " : "раза";
            if (c[i] != 0) Console.WriteLine($"число {i} встречается в данном массиве: {c[i]} {raz}");
        }
    }
}