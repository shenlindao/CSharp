public static class Library
{
    public static int[] MakeArray()
    {
        int[] array = new int[10];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next(1, 100);
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
    public static string SubtractionOfMinMax(int[] array)
    {
        int sub = 0;
        int min = 0;
        int max = 0;
        string output = String.Empty;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[min])
            {
                min = i;
            }
            else if (array[i] > array[max])
            {
                max = i;
            }
        }
        sub = array[max] - array[min];
        output = "Разница между максимальным и минимальным элементом в массиве: " + $"{array[max]} - {array[min]} = {sub}";
        return output;
    }
}