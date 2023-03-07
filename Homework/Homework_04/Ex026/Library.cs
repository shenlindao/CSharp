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

    public static double expNumbers(int[] array)
    {
        return Math.Pow(array[0], array[1]);
    }

    public static string showMessage(int[] array)
    {
        string message = String.Empty;
        for (int i = 0; i < 2; i++)
        {
            string alph = i == 0 ? "A" : "B";
            string? value = GetValue("Введите число " + alph + ": ");
            if (value != null)
            {
                int number = Convert.ToInt32(value);
                if (i == 1 && number < 0)
                {
                    message = "Степень не может быть меньше нуля!";
                    break;
                }
                else
                {
                    array[i] = number;
                    if (i == 1)
                    {
                        message = Convert.ToString(expNumbers(array));
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                message = "Значение не может быть пустым!";
                break;
            }
        }

        return message;
    }
}