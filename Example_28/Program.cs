// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void PrintArray (int[]array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write ($"{array[i]} ");
}
}


int [] GetReverseArray1 (int[] array)
{
    int [] result = new int[array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[array.Length-1-i];
    }
    return result;
}


int [] GetReverseArray2 (int[] array)
{
    int tempStorage = array[0];
    for (int i = 0; i < array.Length / 2 ; i++)
    {   
        tempStorage = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = tempStorage;
    }
    return array;
}

int[] array = new int[] { 1, 4, 6, 3, 7, 9 , 8};
int[] result = GetReverseArray1(array);
PrintArray(result);
result = GetReverseArray2(array);
PrintArray(result);
Console.ReadKey();
