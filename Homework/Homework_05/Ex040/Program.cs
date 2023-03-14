using static Library;

Console.Clear();
Console.WriteLine("Данная программа создаёт одномерный массив вещественных чисел и находит разницу между максимальным и минимальным элементами массива.");
int[] array = MakeArray();
Console.WriteLine(PrintArray(array));
Console.WriteLine(SubtractionOfMinMax(array));