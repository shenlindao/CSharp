using static Library;

Console.Clear();
Console.WriteLine("Данная программа создаёт одномерный массив, заполненный случайными числами и находит сумму чисел массива стоящих на нечетной позиции.");
int[] array = MakeArray();
Console.WriteLine(PrintArray(array));
int sum = SumOfNumbers(array);
Console.WriteLine("Сумма нечётных чисел в массиве = " + sum);