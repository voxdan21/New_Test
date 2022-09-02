// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

void Result (int num1) {
if(num1 % 7 == 0 && num1 % 23 == 0)
{
Console.Write("Кратно");
}
else {
Console.Write(" Не Кратно"); }
}


Result (num1);