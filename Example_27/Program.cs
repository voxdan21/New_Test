
void PrintArray (int[]array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write ($"{array[i]} ");
}
}



int[] GetPairMult(int[] array)
{
    var size = 0;
    int[] result = null;

    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
        result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = array[i] * array[array.Length - i - 1];
        }
    }
    else
    {
        size = (array.Length / 2) + 1;
        result = new int[size];
        for (int i = 0; i < size; i++)
        {
            if (i == size - 1 )
            {
                result[i] = array[i];
            }
            else
            {
                result[i] = array[i] * array[array.Length - i - 1];
            }
        }

    }
    return result;
}


int[] array = new int[] { 1, 4, 6, 3, 7, 9 , 8};
int[] result = GetPairMult(array);
PrintArray(result);