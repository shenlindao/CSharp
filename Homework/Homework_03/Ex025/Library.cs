public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int sumOfNumbers(int number)
    {
        return number * (number + 1) / 2;
    }
}