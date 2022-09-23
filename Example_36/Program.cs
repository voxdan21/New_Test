// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] myArr = new int[4, 5];

Random ran = new Random();

for (int i = 0; i < myArr.GetLength(0) ; i++)
{
   for (int j = 0; j < myArr.GetLength(1); j++)
   {
    myArr[i, j] = ran.Next(1, 15);
    Console.Write(myArr[i, j]+" ");
   } 
   Console.WriteLine();
}
int temp = 0;
for (int i = 0; i< myArr.GetLength(0); i++)
{
    temp = myArr[i, 0];
    myArr[i, 0] = myArr[i, myArr.GetLength(0)];
    myArr[i, myArr.GetLength(0)] = temp;
}
Console.WriteLine();

for (int i = 0; i < myArr.GetLength(0) ; i++)
{
   for (int j = 0; j < myArr.GetLength(1); j++)
   {
    
    Console.Write(myArr[i, j]+" ");
   } 
   Console.WriteLine();
}