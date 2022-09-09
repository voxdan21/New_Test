// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

string NewRandomeMassive()
{
    int[] random;
    random = new int[7];
    string mass = string.Empty;
    for (int i = 0; i < 7; i++)
    {
        random[i] = new Random().Next(0,2);
        mass = mass + random[i];
    }
    return mass;
}

string Result = NewRandomeMassive();
Console.WriteLine(Result);