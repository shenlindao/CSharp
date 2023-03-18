public static class Library
{
    public static string? GetValue(string text)
    {
        Console.Write(text);
        string? value = Console.ReadLine();
        if (value == String.Empty) value = null;
        return value;
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

    public static (int str, int col) SetPosition(int str, int col)
    {
        string err = "Значение не может быть пустым!";
        string? valueStr = GetValue("Задайте позицию элемента по строкам: ");
        if (valueStr == null)
        {
            Console.WriteLine(err);
        }
        else
        {
            str = Convert.ToInt32(valueStr) - 1;

            string? valueCol = GetValue("Задайте позицию элемента по столбцам: ");
            if (valueCol == null)
            {
                Console.WriteLine(err);
            }
            col = Convert.ToInt32(valueCol) - 1;
        }
        return (str, col);
    }

    public static void FindElemet(int[,] array, int str, int col)
    {
        if (str < 0 | str > array.GetLength(0) - 1 | col < 0 | col > array.GetLength(1) - 1)
        {
            Console.WriteLine("По заданным значениям элемент не существует");
        }
        else
        {
            Console.WriteLine($"Значение элемента массива =  {array[str, col]}");
        }
    }

}
