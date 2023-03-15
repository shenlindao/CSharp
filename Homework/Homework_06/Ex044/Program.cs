using static Library;

Console.Clear();
Console.WriteLine("Данная программа находит точку пересечения (X и Y) двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите значения b1, k1, b2 и k2");

String[] key = new string[4] { "b1", "k1", "b2", "k2" };
double?[] value = new double?[4];
GetNumbers(key, value);

var res = GetResult(value);
double? x = res.x;
double? y = res.y;

if (!errString(value) && !errInput(value))
{
    outputString(x, y);
}
else
{
    outputErr();
}