using static Library;

Console.Clear();
Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе");
string? value = GetValue("Введите число: ");
Console.WriteLine(sumDigs(value));