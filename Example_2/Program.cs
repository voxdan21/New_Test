Console.Write("Введи число №1: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введи число №2: ");
int number_2 = int.Parse(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(number_2, 2));
if  (result == number_1) 
{
Console.WriteLine("Да");
}
else 
{
Console.WriteLine("Нет");
}