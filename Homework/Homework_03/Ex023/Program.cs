using static Library;

Console.Clear();
Console.WriteLine("Программа показывает таблицу квадратов чисел от 1 до N");
int n = GetNumber("Введите конечное число: ");
Console.Write(GetResult(n));