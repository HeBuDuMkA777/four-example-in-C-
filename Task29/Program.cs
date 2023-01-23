using System;
using static System.Console;

Clear();

WriteLine("По условию задачи введите восемь чисел!");
WriteLine($"[{String.Join(",", GreatArray(8))}]");


int[] GreatArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Write("Введите число: ");
        result[i] = int.Parse(ReadLine());
    }
    return result;
}