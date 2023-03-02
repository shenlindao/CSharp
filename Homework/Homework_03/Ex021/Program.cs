using static Library;

Console.WriteLine("Давайте проверим является ли введённое пятизначное число палиндромом");
int n = GetNumber("Введите пятизначное число: ");
int reverse = GetReverse(n);
if (ValidateNumber(n))
{
    if (Compare(n, reverse))
    {
        Console.WriteLine("Ответ: Да - введённое число является палиндромом");
    }
    else
    {
        Console.WriteLine("Ответ: Нет - ведённое число НЕ является палиндромом");
    };
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}

