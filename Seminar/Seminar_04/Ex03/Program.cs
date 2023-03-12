//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.Write("Введите число ");
int countN = Convert.ToInt32(Console.ReadLine());

Multi(countN);

void Multi(int countN)
{
int Result = 1;
for(int i = 1; i <= countN; i++)
{
    Result = Result * i;
}
Console.Write(Result);
}
