// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

string GetSquareTable(int n)
{
    string squreString = "";
    for (int i = 1; i <= n; i++)
    {
        if (i == n)
        {
            squreString = squreString + $"{i * i}";
        }
        else
        {
            squreString = squreString + $"{i * i}, ";
        }
    }
    return squreString;

}


Console.Write("Input number: ");
int x = int.Parse(Console.ReadLine());
Console.Write(GetSquareTable(x));