//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Write("Введите число ");
string countN = Console.ReadLine();

Count(countN);

void Count(string countN)
{
       Console.Write(countN.Length);
}
