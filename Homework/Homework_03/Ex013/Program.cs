using static Library;

Console.Clear();
Console.WriteLine("Программа выясняет, кратно ли первое число (A) второму (B), если нет, выводит остаток.");
int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");

bool isMult = IsMult(numberA, numberB);

if (isMult) {
    System.Console.WriteLine("число " + numberA + " кратно " + numberB);
} else {
    System.Console.WriteLine(NoMult(numberA, numberB));
}