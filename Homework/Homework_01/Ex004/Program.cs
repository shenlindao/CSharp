// Convert.ToInt32 конвертируем введенное число из строки в целое число
int a;
int b;
int c;
int max;

Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

if ((a > b) & (a > c))
{
    max = a;
    Console.Write("Наибольшее число: " + max);
}
else if ((b > a) & (b > c))
{
    max = b;
    Console.Write("Наибольшее число: " + max);
}
else
{
    max = c;
    Console.Write("Наибольшее число: " + max);
}
