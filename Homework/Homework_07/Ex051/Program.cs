using static Library;

Console.Clear();
Console.WriteLine("Программа задаёт двумерный массив размером M × N, заполненный случайными вещественными числами.");
int M = 0;
int N = 0;

var set = SetNumbers(M, N);
M = set.M;
N = set.N;

int[,] array = new int[M, N];
array = FillArray(array);

PrintArray(array);