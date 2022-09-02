

Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine());

void SecondNumber(int num1){

while (num > 100)
{num = num/10;}
int result = num%10;
Console.WriteLine($"Вторая цифра в числе {num1} = {result}");
}

SecondNumber(num);