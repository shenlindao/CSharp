public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static bool IsMult(int numberA, int numberB)
    {
        return numberA % numberB == 0 ? true : false;
    }

    public static int NoMult(int numberA, int numberB)
    {
        return numberA % numberB;
    }
}