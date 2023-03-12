//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.Write("Введите число ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Sum(NumberA);

void Sum(int NumberA)
{
int Sum = 0;
for(int i = 0; i <= NumberA; i++)
{
    Sum = Sum + i;
}
Console.Write(Sum);
}

