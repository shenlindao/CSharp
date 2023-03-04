public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static double GetDistance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
    {
        double result = Math.Sqrt(Math.Pow(Ax - Ay, 2) + Math.Pow(Bx - By, 2) + Math.Pow(Az - Bz, 2));
        return result;
    }
}