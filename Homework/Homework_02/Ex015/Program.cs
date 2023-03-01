int GetNumber (string text) {
    Console.Write(text);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}


string CheckWeekend (int number) {
    bool ValidateNumber (int number) {
        return number >= 1 && number <= 7;
    };
    if (ValidateNumber(number)) {
        if (number > 5) {
            string result = "Да";
            return result;
        } else {
            string result = "Нет";
            return result;
        }
    } else {
        string result = "Неверно введён номер дня недели";
        return result;
    }
}

Console.WriteLine("Давайте проверим, является ли день выходным");
int number = GetNumber("Введите номер дня недели (от 1 до 7): ");
string weekEnd = CheckWeekend(number);
Console.WriteLine(weekEnd);