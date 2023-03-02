int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string GetResult(int N)
{
    string res;
    for (int i = 1; i < N; i++)
    {
        int K = i * i * i;
        string res = Console.WriteLine(K.ToString() + "  i= " + i.ToString());
    }
    return res;
}

int N = GetNumber("Введите конечное число: ");
Console.WriteLine(GetResult(N));