using static Library;

Console.Clear();

Console.WriteLine("Данная программа находит произведение двух матриц.");
Console.WriteLine();

int[,] arrayA = new int[3,5];
int[,] arrayB = new int[3,5];

FillArray(arrayA);
FillArray(arrayB);

Console.WriteLine("Ваши исходные матрицы:");
Console.WriteLine();

PrintArray(arrayA);
Console.WriteLine();

PrintArray(arrayB);
Console.WriteLine();

int[,] mult = MultArray(arrayA, arrayB);

Console.WriteLine("Произведение двух матриц:");
Console.WriteLine();

PrintArray(mult);
Console.WriteLine();