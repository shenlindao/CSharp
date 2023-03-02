// Convert.ToInt32 конвертируем введенное число из строки в целое число
int N;
int i;
bool notEven = true;
Console.WriteLine("Программа выводит чётные числа от 1 до N (максимальное число 100)");
Console.WriteLine("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());
if (N > 100)
{
    Console.Write("Слишком большое число");
}
else
{
    for (i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + ", ");
            notEven = false;
        }
    }
    if (notEven)
    {
        Console.Write("Нет чётных чисел");
    }
}

