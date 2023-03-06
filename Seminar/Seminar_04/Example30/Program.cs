using static Library;

Console.Clear();
Console.WriteLine("Программа выводит массив из N элементов, заполненный 0 и 1 в случайном порядке, где первый элемент массива не равен 0");
string? value = GetValue("Введите число N: ");
if (value != null)
{
    int number = Convert.ToInt32(value);
    int[] output = arrayNum(number);
    Console.WriteLine(string.Join(" ", output));
}
else
{
    Console.WriteLine("Значение не может быть пустым!");
}