using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int numA = int.Parse(ReadLine());
WriteLine("В какую степень его возвести? ");
int numB = int.Parse(ReadLine());

WriteLine($"Ответ {GetExponent(numA, numB)}");




int GetExponent(int number, int exponent)
{
    int result = number;
    for (int i = 1; i < exponent; i++)
    {
        result *= number;
    }
    return result;
}