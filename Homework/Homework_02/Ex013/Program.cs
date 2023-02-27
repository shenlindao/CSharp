int GetNumber (string text) {
    Console.Write(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

string findThirdNumberOfN (int nLength, int number) {
    if ( nLength >= 3 ) {
        while (number > 999) { // Нужна помощь, пробовал ставить while (nLength > 3) - терминал виснет, почему так? пришлось поменять цикл.
            number = number / 10;
        }
        int thirdOfN = number % 10;
        string result = "Третья цифра введённого числа: " + thirdOfN;
        return result;
    } else {
        string result = "Третьей цифры нет!";
        return result;
    }
};

int number = GetNumber("Введите число: ");
int nLength = number.ToString().Length;
string output = findThirdNumberOfN(nLength, number);
Console.WriteLine(output);