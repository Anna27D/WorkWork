//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] matrix, int PositionM, int PositionN)
{
    bool N = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (PositionM == i && PositionN == j)
            {
                N = true;
                Console.WriteLine($"Число на позиции: {matrix[i, j]}");
                break;
            }
        }
    }
    if (N == false)
    {
        Console.WriteLine("Такого числа в массиве нет.");
    }
}

int m = GetNumber("Введите количество строк в массиве: ");
int n = GetNumber("Введите количество столбцов в массиве: ");
Console.WriteLine();

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine("Массив: ");
PrintArray(matrix);
Console.WriteLine();

int PositionM = GetNumber("Введите строку позиции элемента: ");
int PositionN = GetNumber("Введите столбец позиции элемента: ");
Console.WriteLine();

FindElement(matrix, PositionM, PositionN);
