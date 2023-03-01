int GetNumber (string text) {
    Console.Write(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

string checkDigits(int number) {
    bool ValidateNumber(int number) {
       return number >= 10 && number < 99 ? true : false;
    }
    if (ValidateNumber(number)) {
        int a = number % 10;
        int b = number / 10 % 10;
        int biggerDigit (int number) {
            int bigger;
            return a < b ? bigger = b : bigger = a;
        }
        string result = "Наибольшее число: " + biggerDigit(number);
        return result;
    } else {
        string result = "Было введено число вне заданного диапозона";
        return result;
    }
}

int number = GetNumber("Введите число из отрезка [10, 99]: ");
if (number < 0) number *= -1;
string output = checkDigits(number);
Console.WriteLine(output);