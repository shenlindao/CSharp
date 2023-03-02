int GetNumber(string text)
{
    Console.WriteLine(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

string findSecondDigitOfN(int number)
{
    bool ValidateNumber(int number)
    {
        return number < 999 ? true : false;
    }
    if (ValidateNumber(number))
    {
        int lastOfN = number = number % 10;
        string result = "Последняя цифра введённого числа: " + lastOfN;
        return result;
    }
    else
    {
        string result = "Было введено не трёхзначное число!";
        return result;
    }
}

int number = GetNumber("Введите трёхзначное число: ");
if (number < 0) number *= -1;
string output = findSecondDigitOfN(number);
Console.WriteLine(output);