﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] GetArray(int size, int startValue, int endValue)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);

    }
    return array;
}


int GetSumPositiveNumbers(int[]array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            sum = sum + array[i];
        }
       
    }
    return sum;
}

int GetSumNegativeNumbers(int[]array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
        {
            sum = sum + array[i];
        }
       
    }
    return sum;

}

int[] array = GetArray(12,-9,9);
int sumPositive = GetSumPositiveNumbers(array);
int sumNegative = GetSumNegativeNumbers(array);
Console.WriteLine($"Сумма положительных чисел: {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");