using static Library;

Console.Clear();
Console.WriteLine("Программа задаёт предлагает создать одномерный массив любой длины, и считает сколько чисел больше нуля ввёл пользователь");
int length = Convert.ToInt32(GetValue("Напишите количество цифр, которые хотите ввести: "));
int[] array = new int[length];
string? value = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    value = GetValue("Введите число № " + (i + 1) + ": ");
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
// if (value != null) Console.Write("Ваши числа => " + string.Join(", ", array.Take(array.Length - 1)) + ", " + array[length - 1]);
if (value != null) Console.Write("Вы ввели " + NumbersMoreZero(array) + " чисел больше нуля");