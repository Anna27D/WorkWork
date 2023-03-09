//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.Write("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());

Sum(A);

void Sum(int A)
{
int S = 0;
for(int i = 0; i <= A; i++)
{
    S = S + i;
}
Console.Write(S);
}

