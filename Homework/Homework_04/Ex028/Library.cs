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
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            message = "Сумма цифр в числе = " + Convert.ToString(sum);
        }
        else
        {
            message = "Значение не может быть пустым!";
        }
        return message;
    }
}