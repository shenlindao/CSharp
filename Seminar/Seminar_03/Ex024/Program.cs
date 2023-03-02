using static Library;

Console.Clear();
Console.WriteLine("Программа показывает кубы чисел от 1 до N");
int n = GetNumber("Введите конечное число: ");
Console.WriteLine(GetResult(n));