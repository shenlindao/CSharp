using static Library;

Console.Clear();
Console.WriteLine("Данная программа создаст и перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.");
int[] arr = makeArray();
Console.WriteLine(printArray(arr));
ArrayTurn(arr);
Console.WriteLine(printArray(arr));
