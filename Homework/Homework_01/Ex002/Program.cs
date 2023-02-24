// Convert.ToInt32 конвертируем введенное число из строки в целое число
int a, b, max;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    max = a;
    Console.Write("Наибольшее число: " + max);
} else {
    max = b;
    Console.Write("Наибольшее число: " + max);
}
