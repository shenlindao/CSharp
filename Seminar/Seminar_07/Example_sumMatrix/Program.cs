using static Library;

Console.Clear();
int[,] arrayA = new int[3, 4];
int[,] arrayB = new int[3, 4];

arrayA = FillMatrix(arrayA);
arrayB = FillMatrix(arrayB);
Console.WriteLine();
PrintArray(arrayA);

Console.WriteLine();
Console.WriteLine("+");
Console.WriteLine();

PrintArray(arrayB);

int[,] result = GetSumMatrix(arrayA, arrayB);

Console.WriteLine();
Console.WriteLine("=");
Console.WriteLine();

PrintArray(result);
Console.WriteLine();