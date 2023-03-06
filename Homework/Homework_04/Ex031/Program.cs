using static Library;

Console.Clear();
Console.WriteLine("Программа задаёт массив из 8 элементов, и выводит их на экран");
int[] array = new int[8];
string? value = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    value = GetValue("Введите число: ");
    if (value != null)
    {
        int number = Convert.ToInt32(value);
        array[i] = number;
    }
    else
    {
        Console.WriteLine("Значение не может быть пустым!");
        break;
    }
}
if (value != null) Console.Write("Ваш массив => [" + string.Join(", ", array.Take(array.Length - 1)) + ", " + array[7] + "]");