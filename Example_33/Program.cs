// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
        array[i, j] = i + j;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)

    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}