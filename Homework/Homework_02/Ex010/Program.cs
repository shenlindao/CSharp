int GetNumber (string text) {
    Console.Write(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

string findSecondNumberOfN (int nLength, int number) {
    if ( nLength == 3 ) {
        int secondOfN = number / 10 % 10;
        string result = "Вторая цифра введённого числа: " + secondOfN;
        return result;
    } else {
        string result = "Требуется ввести трёхзначное число!";
        return result;
    }
};

int number = GetNumber("Введите трёхзначное число: ");
int nLength = number.ToString().Length;
string output = findSecondNumberOfN(nLength, number);
Console.WriteLine(output);