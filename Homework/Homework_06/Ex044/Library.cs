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

    public static double?[] GetNumbers(string[] key, double?[] value)
    {
        for (int i = 0; i < key.Length; i++)
        {
            string? getValue = (GetValue($"Введите значение {key[i]} :> "));
            value[i] = Convert.ToDouble(getValue);
            if (getValue == null)
            {
                Console.WriteLine("Значение не может быть пустым!");
                break;
            }
        }
        return value;
    }

    // Формула
    // x = (b1 - b2) / (k2 - k1)
    // y = ((k2 * b1) - (k1 * b2)) / (k2 - k1)

    public static bool errString(double?[] value)
    {
        return value[3] - value[1] == 0 ? true : false;
    }

    public static bool errInput(double?[] value)
    {
        bool err = true;
        for (int i = 0; i < 4; i++)
        {
            if (value[i] == null)
            {
                err = true;
            }
            else
            {
                err = false;
            }
        }
        return err;
    }

    public static (double? x, double? y) GetResult(double?[] value)
    {
        double? resultX;
        double? resultY;

        resultX = (value[0] - value[2]) / (value[3] - value[1]);

        resultY = ((value[3] * value[0]) - (value[1] * value[2])) / (value[3] - value[1]);

        return (resultX, resultY);
    }
    public static void outputErr()
    {
        Console.WriteLine("Не возможно найти точку пересечения.");
    }

    public static void outputString(double? x, double? y)
    {
        Console.WriteLine($"Точка пересечения двух прямых X = {x} и Y = {y}");
    }
}