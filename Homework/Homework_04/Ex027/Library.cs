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

    public static string? sumDigs(string? value)
    {
        string? message = String.Empty;
        if (value != null)
        {
            int num = Convert.ToInt32(value);
            int col = 0;
            while (num > 0)
            {
                col += 1;
                num /= 10;
            }
            message = "Количество цифр в числе = " + Convert.ToString(col);
        }
        else
        {
            message = "Значение не может быть пустым!";
        }
        return message;
    }
}