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

    public static int[] arrayNum(int number)
    {
        int[] arr = new int[number];
        int min = 0;
        int max = 1;
        for (int i = 0; i < number; i++)
        {
            arr[i] = new Random().Next(min, max + 1);
        }
        arr[0] = 1;
        return arr;
    }
}