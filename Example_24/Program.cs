// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

bool Metod (int [] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
       if (array [i] == number) 
       {
            result = true;
            break;
       }
       else result = false;
       
    }
    return result;
}

try
{
    Console.Write ("Введите число: ");
    int number = Convert.ToInt32 (Console.ReadLine ()); 
    int [] array = {5, -4, 5, -1, 0};
    var result = Metod (array, number);
    Console.WriteLine(result);
}

catch
{
    Console.Write ("Ошибка: не верно введены данные.");
}
