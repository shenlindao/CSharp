int GetNumber (string text) {
    Console.Write(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

string DelSecondDigit (int number) {
    bool ValidateNumber(int number) {
    return number < 999 ? true : false;
    }
    if (ValidateNumber(number)) {
        int firstOfN = number / 100 % 10;
        int lastOfN = number % 10;
        int resultNumber = firstOfN * 10 + lastOfN;
        string result = Convert.ToString(resultNumber);
        return result;
    } else {
        string result = "Введено не трёхзначное число!";
        return result;
    }
}

int number = GetNumber("Введите трёхзначное число: ");
if (number < 0) number *= -1;
string output = DelSecondDigit(number);
Console.WriteLine(output);