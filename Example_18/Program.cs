﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36



int GetSum(int number)
{
    int sum = 0;
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            sum = sum + i;
        }
    }
    if (number < 0)
    {
        for (int i = 1; i >= number; i--)
        {
            sum = sum + -i;
        }
    }
    return sum;
}



Console.Write("Input A:  ");

try
{
    int a = int.Parse(Console.ReadLine());
    int sum = GetSum(a);
    Console.WriteLine(sum);
}
catch (Exception ex)
{
 Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}

