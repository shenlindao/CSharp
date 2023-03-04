public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            number *= -1;
        }
        return number;
    }

    public static bool ValidateNumber(int number)
    {
        return number > 9999 && number <= 99999;
    }

    public static int GetReverse(int n)
    {
        int reverse = 0;
        while (n > 0)
        {
            int dig = n % 10;
            reverse = reverse * 10 + dig;
            n = n / 10;
        }
        return reverse;
    }

    public static bool Compare(int n, int reverse)
    {
        if (n == reverse)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
