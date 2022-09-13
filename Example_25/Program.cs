// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] GetArray (int size)
{
    var array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1,1000);
    }
    return array;
}

void PrintArray (int[]array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write ($"{array[i]} ");
}
}


int Metod (int[] array, int start, int end)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i]>start && array[i]<end+1)
         sum ++;
    }
    return sum;
}

try

{
Console.WriteLine ("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите начало отрезка:");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите конец отрезка:");
int end = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size);
PrintArray(array);
int sumNumber = 0;
sumNumber = Metod (array,start,end);
Console.WriteLine("");
Console.WriteLine (sumNumber);

}
catch (Exception ex)
{
 Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}
