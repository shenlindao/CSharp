public static class Library
{
    public static int[] makeArray()
    {
        int[] array = new int[5];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next(1, 10);
        return array;
    }
    public static string printArray(int[] array)
    {
        string nArray = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            nArray = nArray + array[i] + " ";
        }
        return nArray;
    }
    public static int[] ArrayTurn(int[] arr)
    {
        int arrEnd = arr.Length - 1;

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int x = arr[i];
            arr[i] = arr[arrEnd];

            arr[arrEnd] = x;

            arrEnd -= 1;
        }
        return arr;
    }
}