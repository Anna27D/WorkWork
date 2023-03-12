//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число ");
int  NumberA = Convert.ToInt32(Console.ReadLine());

Sum(NumberA);

void Sum(int NumberA)
{
    int Result = 0;
    while (NumberA > 0)
    {
        Result += NumberA % 10;
        NumberA /= 10;
    }
    Console.Write(Result);
}
