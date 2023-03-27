using static Library;

Console.Clear();
Console.WriteLine("Программа показывает сумму чисел от N до 1");
int number = SetNumbers();
Console.Write(number + " ");
int count = 1;
Decrease(number, count);