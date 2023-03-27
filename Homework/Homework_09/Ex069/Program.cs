using static Library;

Console.Clear();
Console.WriteLine("Данная программа позволяет задать значения M и N, а затем находит сумму натуральных элементов в промежутке от M до N.");
var res = SetNumbers();
int M = res.M;
int N = res.N;
if (M < 1 | N < 1) Console.WriteLine("Программа работает только с натуральными числами");
else Console.WriteLine(ElemSum(M, N));