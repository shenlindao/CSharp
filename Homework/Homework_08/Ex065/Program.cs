using static Library;

Console.Clear();

Console.WriteLine("Данная программа формирует массив 4 на 4, и заполняет его числами по спирали.");
Console.WriteLine();

int[,] array = new int[4,4];

FillArray(array);
PrintArray(array);
Console.WriteLine();