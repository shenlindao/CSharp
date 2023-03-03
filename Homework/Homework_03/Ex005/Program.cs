using static Library;

Console.Clear();

Console.WriteLine("Данная программа вычисляет значение функции y = sin(a)");
double a = GetNumber("Введите число (a): ");
double y = sinOfNumer(a);
System.Console.WriteLine(y + " = sin(" + a + ")");