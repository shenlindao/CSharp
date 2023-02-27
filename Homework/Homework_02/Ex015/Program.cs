int GetNumber (string text) {
    Console.Write(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

bool ValidateNumber (int number) {
    return number >= 1 && number <= 7;
};

int number = GetNumber("Введите номер дня недели (от 1 до 7): ");
bool output = ValidateNumber(number);
Console.WriteLine(output);