﻿//Напишите программу, которая принимает на вход три числа
//и проверяет, может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: Каждая сторона треугольника меньше суммы двух других сторон.

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

void CheckSides(int SideA, int SideB, int SideC)
{
    int Sum1 = SideA + SideB;
    int Sum2 = SideB + SideC;
    int Sum3 = SideA + SideC;
    if (Sum1 > SideC && Sum2 > SideA && Sum3 > SideB)
    {
        Console.WriteLine("Такой треугольник существует.");
    }
    else
    {
        Console.WriteLine("Такой треугольник не существует.");
    }
}

int SideA = GetNumber("Введите первое число ");
int SideB = GetNumber("Введите второе число ");
int SideC = GetNumber("Введите третье число ");
Console.WriteLine();
CheckSides(SideA, SideB, SideC);
