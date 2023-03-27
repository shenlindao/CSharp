public static class Library
{
    public static string? GetValue(string text)
    {
        Console.Write(text);
        string? value = Console.ReadLine();
        if (value == String.Empty) value = null;
        return value;
    }

    public static int SetNumbers()
    {
        int N = 0;
        string err = "Значение не может быть пустым!";
        string? valueM = GetValue("Введите число N: ");
        if (valueM == null) Console.WriteLine(err);
        else N = Convert.ToInt32(valueM);
        return N;
    }

    public static void Decrease(int number, int count)
    {
        if (count < number)
        {
            Decrease(number, count + 1);
            Console.Write(count + " ");
        }
    }
}