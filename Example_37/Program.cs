// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] myArr = new int[2, 2];

Random ran = new Random();

for (int i = 0; i < myArr.GetLength(0) ; i++)
{
   for (int j = 0; j < myArr.GetLength(1); j++)
   {
    myArr[i, j] = ran.Next(1, 6);
    Console.Write(myArr[i, j]+" ");
   } 
   Console.WriteLine();
}


int[,] myArrX = new int[myArr.GetLength(0), myArr.GetLength(1)];

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    { 
       myArrX[i,j] = myArr[j,i];
    }
}

Console.WriteLine();

for (int i = 0; i < myArr.GetLength(0) ; i++)
{
   for (int j = 0; j < myArr.GetLength(1); j++)
   {
    
    Console.Write(myArrX[i, j]+" ");
   } 
   Console.WriteLine();
}