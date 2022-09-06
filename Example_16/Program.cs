// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double GetDistance (int x1, int y1, int x2, int y2)
{   
    double distance = Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2));
    return Math.Round(distance,2,MidpointRounding.ToNegativeInfinity);
}




Console.Write("Input X(1 number): ");
int x = int.Parse(Console.ReadLine());

Console.Write("Input Y(1 number): ");
int y = int.Parse(Console.ReadLine());

Console.Write("Input X(2 number): ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Input Y(2 number): ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine(GetDistance(x,y,x1,y1));