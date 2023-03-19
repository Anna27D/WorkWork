//Найти произведение двух матриц. 
//https://www.webmath.ru/poleznoe/formules_6_6.php

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
            matrix[i, j] = new Random().Next(1, 10); // [1, 10)
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

void MatrixMulti(int[,] matrix, int[,] matrix2, int[,] Multi)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Multi[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
}

int m = GetNumber("Введите количество строк в массиве: ");
int n = GetNumber("Введите количество столбцов в массиве: ");
Console.WriteLine();

int[,] matrix = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] Multi = new int[m, n];

FillArray(matrix);
FillArray(matrix2);
Console.WriteLine();
Console.WriteLine("Первая матрица: ");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);
Console.WriteLine();
MatrixMulti(matrix, matrix2, Multi);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(Multi);
