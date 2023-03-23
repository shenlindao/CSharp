using static Library;

Console.Clear();

Console.WriteLine("Данная программа формирует трёхмерный массив с не повторяющимися двузначными числами и показывает его построчно на экран, выводя индексы соответствующего элемента.");
Console.WriteLine();

int[,,] array = new int[3,4,5];

FillArray(array);
PrintArray(array);
Console.WriteLine();