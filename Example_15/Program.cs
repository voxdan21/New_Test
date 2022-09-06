// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


string Diaposon(int number)
{
    if (number == 1)
    {
        return "x>0,y>0";
    }
    if (number == 2)
    {
        return "x<0,y>0";
    }
    if (number == 3)
    {
        return "x<0,y<0";
    }
    if (number == 4)
    {
        return "x>0,y<0";
    }
    else
        return "mistake";
}



Console.Write("Input Area: ");
int Area = int.Parse(Console.ReadLine());
Console.WriteLine(Diaposon(Area));