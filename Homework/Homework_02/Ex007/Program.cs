int GetNumber(string text) {
    Console.WriteLine(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

bool ValidateNumber (int number) {
    if (number <= 100) {
        return true;
    } else {
        return false;
    }
}

Console.WriteLine("Программа выводит числа от -N до N (максимальное число 100)");
int number = GetNumber("Введите число N: ");
bool validete = ValidateNumber(number);

if (ValidateNumber(number)) {
    for (int i = -number; i <= number; i++) {
    Console.Write(i + " ");
    }
} else {
    Console.WriteLine("Слишком большое число");
}