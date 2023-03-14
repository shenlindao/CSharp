public static class Library
{
    public static int[] MakeArray()
    {
        int[] array = new int[10];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next(100, 999);
        return array;
    }
    public static string PrintArray(int[] array)
    {
        string nArray = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            nArray = nArray + array[i] + " ";
        }
        return nArray;
    }
    public static int PositiveNumbers(int[] array)
    {
        int positive = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                positive += 1;
            }
        }
        return positive;
    }
}