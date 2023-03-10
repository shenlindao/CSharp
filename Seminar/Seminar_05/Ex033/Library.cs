using System;
public static class Library
{
    public static string? GetValue(string text)
    {
        Console.Write(text);
        string? value = Console.ReadLine();
        if (value == String.Empty)
        {
            value = null;
            return value;
        }
        else
        {
            return value;
        }
    }

    public static string sumOfNumbers(int[] array)
    {
        int sumPositive = 0;
        int sumNegative = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int digPos = array[i] > 0 ? array[i] : 0;
            sumPositive += digPos;
            int digNeg = array[i] < 0 ? array[i] : 0;
            sumNegative += digNeg;
        }
        string result = "Сумма положительных чисел = " + sumPositive + ". Сумма отрицательных чисел = " + sumNegative + ".";
        return result;
    }
}