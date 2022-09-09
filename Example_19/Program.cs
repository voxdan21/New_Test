// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int HowMuchNumber(double a)
{
    int count = 1;
    a = Math.Abs(a);
    while (a > 10)

    {
        a = a / 10;
        count++;
    }
    return count;
}


try
{
    Console.Write("Input number: ");
    double a = int.Parse(Console.ReadLine());
    int amountNumber = HowMuchNumber(a);
    Console.WriteLine(amountNumber);
}
catch (Exception ex)
{
    Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}