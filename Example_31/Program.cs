// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double[] Fibonachi(int a)
{
    double[] fibo = new double[a];
    if (a == 1)
    {
        fibo[0] = 0; 
        return fibo;
    }
    if (a == 2)
    {
        fibo[0] = 0; 
        fibo[1] = 1; 
        return fibo;
    }
    else
    {
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < fibo.Length; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        return fibo;
    }
}

try
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    double[] fibo = new double[x];
    fibo = Fibonachi(x);
    PrintArray(fibo);

}
catch
{
    Console.Write("Ошибка: не верно введены данные.");
}