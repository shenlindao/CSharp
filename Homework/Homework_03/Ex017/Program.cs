using static Library;

Console.Clear();
Console.WriteLine("Программа выясняет, является ли первое число (A) квадратом второго (B).");
int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");

bool isSqur = IsSqur(numberA, numberB);

if (isSqur)
{
    System.Console.WriteLine("число " + numberA + " является квадратом " + numberB);
}
else
{
    System.Console.WriteLine("число " + numberA + " НЕ является квадратом " + numberB);
}