public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static double sinOfNumer(double a)
    {
        double y = Math.Sin(a);
        return y;
    }
}