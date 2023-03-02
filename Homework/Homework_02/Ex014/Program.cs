int GetNumber(string text)
{
    Console.Write(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

string findThirdNumberOfN(int number)
{
    if (number > 999)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        int thirdOfN = number % 10;
        string result = "Третья цифра введённого числа: " + thirdOfN;
        return result;
    }
    else
    {
        string result = "Третьей цифры нет!";
        return result;
    }
};

int number = GetNumber("Введите число: ");
if (number < 0) number *= -1;
string output = findThirdNumberOfN(number);
Console.WriteLine(output);