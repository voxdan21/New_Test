void SecondNumber(int a){
int num = a;
while (num > 100)
{num = num/10;}
int result = num%10;
Console.WriteLine($"Вторая цифра в числе {a} = {result}");
}




Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine());



SecondNumber(num);