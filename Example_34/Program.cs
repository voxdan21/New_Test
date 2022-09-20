// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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


for (int i = 0; i < n; i+=2)
{
    for (int j = 0; j < m; j+=2)

    {
        array[i,j] = array[i,j] * array[i,j];
    }
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)

    {
        Console.Write(array[i,j]+ " ");
    }
Console.WriteLine();
}