using static Library;

Console.Clear();

Console.WriteLine("Данная програма задаёт двумерный массив из целых чисел и находит среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();

int[,] array = new int[3,4];
FillArray(array);

Console.WriteLine("Ваш исходный массив:");
PrintArray(array);

Console.WriteLine();

Arithmetic(array);