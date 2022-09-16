// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool CheckTriangle (int a, int b, int c)
{
    if (a+b > c && a+c > b && c+b > a)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

try
{
    Console.Write("Введите сторону A: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите сторону B: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите сторону B: ");
    int z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(CheckTriangle(x,y,z));
}
catch
{
    Console.Write("Ошибка: не верно введены данные.");
}