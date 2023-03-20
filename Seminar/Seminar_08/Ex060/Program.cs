using static Library;

Console.Clear();
Console.WriteLine("Данная программа составляет частотный словарь элементов двумерного массива, заданный M и N, где M - количество строк, а N количество столбцов.");

int M = 0;
int N = 0;

var set = SetNumbers(M, N);
M = set.M;
N = set.N;

int[,] array = new int[M, N];
array = FillArray(array);

PrintArray(array);

int m = GetLargestNumber(array);
Frequency(array, m);