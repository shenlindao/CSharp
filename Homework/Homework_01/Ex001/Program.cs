int GetNumberA(string textA)
{
    Console.Write(textA);
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}

int GetNumberB(string textB)
{
    Console.Write(textB);
    int B = Convert.ToInt32(Console.ReadLine());
    return B;
}

bool CheckNumbers(int numberA, int numberB)
{
    return numberB == numberA * numberA ? true : false;
}

Console.WriteLine("Давайте проверим, является ли первое число квадратом второго");
int numberA = GetNumberA("Введите первое число: ");
int numberB = GetNumberB("Введите второе число: ");

if (CheckNumbers(numberA, numberB))
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}