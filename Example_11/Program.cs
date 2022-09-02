

Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine());

void SecondNumber(int num){
while (num > 100)
{num = num/10;}
int result = num%10;
Console.WriteLine(result);
}

SecondNumber(num);