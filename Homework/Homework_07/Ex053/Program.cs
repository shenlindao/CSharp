using static Library;

Console.Clear();

int[,] array = new int[3,4];
FillArray(array);

Console.WriteLine("Ваш исходный массив:");
PrintArray(array);

Console.WriteLine();

int str = 0;
int col = 0;

var pos = SetPosition(str, col);
str = pos.str;
col = pos.col;

FindElemet(array, str, col);
