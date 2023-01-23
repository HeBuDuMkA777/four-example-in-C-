using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
WriteLine($"Сумма цифр Вашего числа равна {GetSumInt(int.Parse(ReadLine()))}");


int GetSumInt(int Number)
{
    int result = 0;
    int tempNum = Number;
    while (tempNum > 0)
    {
        result += tempNum % 10;
        tempNum /= 10;
    }
    return result;
}