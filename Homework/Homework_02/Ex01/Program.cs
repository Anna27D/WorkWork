﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число ");

string a = Console.ReadLine();

if (a.Length >= 3)
 {
  Console.WriteLine(a[1]);
 }
else
{
   Console.Write("Вы ввели не трехзначное число");
}