using static Library;

Console.Clear();
Console.WriteLine("Данная программа вычисляет функцию Аккермана с помощью рекурсии, числа M и N задаются пользователем.");
var res = SetNumbers();
int M = res.M;
int N = res.N;
if (M < 0 | N < 0) Console.WriteLine("Программа работает только с неотрицательными числами");
else Console.WriteLine(Akkerman(M, N));