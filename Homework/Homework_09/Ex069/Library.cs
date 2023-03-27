public static class Library
{
    public static string? GetValue(string text)
    {
        Console.Write(text);
        string? value = Console.ReadLine();
        if (value == String.Empty) value = null;
        return value;
    }

    public static (int M, int N) SetNumbers()
    {
        int M = 0, N = 0;
        string err = "Значение не может быть пустым!";
        string? valueM = GetValue("Введите число M: ");
        if (valueM == null) Console.WriteLine(err);
        else
        {
            M = Convert.ToInt32(valueM);
            string? valueN = GetValue("Введите число N: ");
            if (valueN == null) Console.WriteLine(err);
            N = Convert.ToInt32(valueN);
        }
        return (M, N);
    }


    public static int ElemSum(int M, int N)
    {
        if (M > N) return 0;
        return M + ElemSum(M + 1, N);
    }
}