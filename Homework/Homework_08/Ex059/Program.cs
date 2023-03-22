using static Library;

Console.Clear();

Console.WriteLine("Данная программа задаёт прямоугольную матрицу и находит строку с наименьшей суммой элементов.");
Console.WriteLine();

int[,] array = new int[8,6];
FillArray(array);

Console.WriteLine("Ваш исходный массив:");
PrintArray(array);

Console.WriteLine();

GetRowMinValue(array);