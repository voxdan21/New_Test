// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


string GetDecimalFromStingInt (string fakeInt)
{
    string fakeDecimal = null ;
    int i = int.Parse(fakeInt);
    while ( i != 0 )
    {
        int temp = i%2;
        fakeDecimal = (temp+ fakeDecimal);
        i /= 2; 
    }
    return fakeDecimal;
}

Console.WriteLine(GetDecimalFromStingInt("45"));
