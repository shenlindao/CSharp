using static Library;

Console.Clear();
Console.WriteLine("Программа показывает сумму чисел от 1 до A");
int number = GetNumber("Введите конечное число (A): ");
Console.Write(sumOfNumbers(number));
