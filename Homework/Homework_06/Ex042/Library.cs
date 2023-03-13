public static class Library
{
    public static string? GetValue(string text)
    {
        Console.Write(text);
        string? value = Console.ReadLine();
        if (value == String.Empty)
        {
            value = null;
            return value;
        }
        else
        {
            return value;
        }
    }
    public static int NumbersMoreZero(int[] array)
    {
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            num = array[i] > 0 ? num + 1 : num + 0;
        }
        return num;
    }
}