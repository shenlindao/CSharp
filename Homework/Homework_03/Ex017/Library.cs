public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static bool IsSqur(int numberA, int numberB)
    {
        return numberA * numberA == numberB ? true : false;
    }
}