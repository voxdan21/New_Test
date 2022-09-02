// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
void numbers(int num1, int num2)
{
    if (num1 % num2 == 0) Console.WriteLine("Первое число кратно второму");
    else Console.WriteLine($"Первое число не кратно второму, остаток {num1 % num2}");

}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

numbers(num1, num2);
Console.WriteLine();
