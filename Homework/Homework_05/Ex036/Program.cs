using static Library;

Console.Clear();
Console.WriteLine("Данная программа создаёт массив, заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве.");
int[] array = MakeArray();
Console.WriteLine(PrintArray(array));
int positive = PositiveNumbers(array);
Console.WriteLine("Количество чётных чисел в массиве = " + positive);