public static class Library
{
    public static string? GetName(string text)
    {
        Console.Write(text);
        string? name = Console.ReadLine();
        if (name == String.Empty)
        {
            name = null;
            return name;
        }
        else
        {
            return name;
        }
    }
}