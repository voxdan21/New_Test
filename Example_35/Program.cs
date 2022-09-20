// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
        array[i, j] = new Random().Next(1, 10);
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
int result = 0;

if (m < n)
{
    for (int j = 0; j < m; j++)
    {
        result = result + array[j, j];
    }
}
else
{
  for (int j = 0; j < n; j++)
    {
        result = result + array[j, j];
    } 
}

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)

//     {
//         if (i==j) result = result + array[i,j];
//     }
// Console.WriteLine();
// }
Console.WriteLine(result);