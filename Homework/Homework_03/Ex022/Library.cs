public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static double GetDistance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
    {
        double result = Math.Sqrt(Ax * Ax + Ay * Ay + Az * Az);
        return result;
    }
}