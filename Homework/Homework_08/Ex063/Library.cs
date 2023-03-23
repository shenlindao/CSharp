public static class Library
{
    public static int[,,] FillArray(int[,,] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int e = 0; e < array.GetLength(2); e++)
                {
                    array[i, j, e] = rand.Next(10, 99);
                }
            }
        }
        return array;
    }

    public static void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int e = 0; e < array.GetLength(2); e++)
                {
                   Console.WriteLine( $"array([{i}, {j}, {e}]) = {array[i, j, e]}; ");
                }
            }
            Console.WriteLine();
        }
    }
}