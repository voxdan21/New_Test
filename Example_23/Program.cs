// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

int[] Metod(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

try
{
    int[] array = { 5, -4, 5, -1, 0 };
    int[] newArray = Metod(array);
    PrintArray(newArray);
}

catch
{
    Console.Write("Ошибка: не верно введены данные.");
}
