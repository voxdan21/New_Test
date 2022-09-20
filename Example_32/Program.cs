// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Размерность массива колличества строк
int n = 0;

// Размерность массива колличества столбцов
int m = 0;

Console.Write("Введите колличество строк (N): ");
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    n = numberN;
}

Console.Write("Введите колличество столбцев (M): ");
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    m = numberM;
}

int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)

    {
        array[i,j] = new Random().Next(1,10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)

    {
        Console.Write(array[i,j]+ " ");
    }
Console.WriteLine();
}