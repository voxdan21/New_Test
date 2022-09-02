void SecondNumber(int a)
{
    int num = a;

    if (a < 10 && a >= 0)
    {
        Console.WriteLine("Нет второй цифры");
    }

    else if (a < 0)
    {
        num = num * -1;
        while (num > 100)
        { num = num / 10; }
        int result = num % 10;
        if (a < 10 && a >= 0)
        {
            Console.WriteLine("Нет второй цифры");
        }

        Console.WriteLine($"Вторая цифра в числе {a} = {result}");
    }

    else
    {
        while (num > 100)
        { num = num / 10; }
        int result = num % 10;
        if (a < 10 && a >= 0)
        {
            Console.WriteLine("Нет второй цифры");
        }

        Console.WriteLine($"Вторая цифра в числе {a} = {result}");
    }
}

void NumberWithoutSecond(int a)
{
    int num = a;
    string num2 = "";
    if (a < 10 && a >= 0) { Console.WriteLine($"Число без второй цифры:{a}"); }
    else if (a < 0)
    {
        num = num * -1;
        while (num > 100)
        {

            num2 = num % 10 + num2;
            num = num / 10;
        }

        num = num / 10;
        num2 = "-" + num + num2;

        Console.WriteLine($"Число без второй цифры:{num2}");
    }
    else
    {
        while (num > 100)
        {

            num2 = num % 10 + num2;
            num = num / 10;
        }

        num = num / 10;
        num2 = num + num2;

        Console.WriteLine($"Число без второй цифры:{num2}");
    }
}


Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine());

SecondNumber(num);
NumberWithoutSecond(num);
