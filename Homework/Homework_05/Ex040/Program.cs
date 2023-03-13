using static Library;

Console.Clear();
Console.WriteLine("Данная программа создаёт одномерный массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");
int[] array = MakeArray();
Console.WriteLine(PrintArray(array));
Console.WriteLine(SubtractionOfMinMax(array));