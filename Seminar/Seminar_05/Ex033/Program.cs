using static Library;

Console.Clear();
Console.WriteLine("Программа задаёт массив из 12 элементов, заполненных числами из [0,9]. И находит сумму положительных/отрицательных элементов массива");
int[] array = new int[12];
string? value = String.Empty;
bool valid = false;
for (int i = 0; i < array.Length; i++)
{
    value = GetValue("Введите число № " + i + ": ");
    if (value != null)
    {
        int number = Convert.ToInt32(value);
        if ((number < -9) || (number > 9))
        {
            valid = false;
            Console.WriteLine("Число должно быть в диапазоне от -9 до 9!");
            break;
        }
        valid = true;
        array[i] = number;
    }
    else
    {
        Console.WriteLine("Значение не может быть пустым!");
        break;
    }
}

string result = sumOfNumbers(array);
if (valid == true) Console.WriteLine(result);