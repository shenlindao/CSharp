// Convert.ToInt32 конвертируем введенное число из строки в целое число
int N;
string even = "да";
string odd = "нет";
string result;
Console.WriteLine("Давайте проверим, чётное число или нет");
Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0) {
    result = even;
} else {
    result = odd;
}
Console.Write("Ответ: " + result);