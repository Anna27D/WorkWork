﻿//Напишите метод(-ы), который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

Coub(N);

void Coub(int N)
{
for(int i = 1; i <= N; i++)
{
    Console.WriteLine(i*i*i);
}
}
