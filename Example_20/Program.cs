// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetProizved(int number)
{
    int multiplication = 1;
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            multiplication = multiplication * i;
        }
    }
    if (number < 0)
    {
        for (int i = 1; i >= number; i--)
        {
            multiplication = multiplication * i;
        }
    }
    return multiplication;
}



Console.Write("Input A:  ");

try
{
    int a = int.Parse(Console.ReadLine());
    int sum = GetProizved(a);
    Console.WriteLine(sum);
}
catch (Exception ex)
{
 Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}