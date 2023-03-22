using static Library;

Console.Clear();

Console.WriteLine("Данная програма упорядочивает по убыванию элементы каждой строки двумерной массива.");
Console.WriteLine();

int[,] array = new int[8,6];
FillArray(array);

Console.WriteLine("Ваш исходный массив:");
PrintArray(array);

Console.WriteLine();

GetRowMinValue(array);