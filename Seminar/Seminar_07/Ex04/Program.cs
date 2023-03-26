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

void Multiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int Sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                Sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = Sum;
        }
    }
}

int m = GetNumber("Введите количество строк: ");
int k = m;
int n = GetNumber("Введите количество столбцов: ");
int l = n;
Console.WriteLine();
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[l, k];

int[,] resultMatrix = new int[m, k];

FillArray(firstMatrix);
Console.WriteLine("Первая матрица: ");
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintArray(secondMatrix);
Console.WriteLine();
Multiplication(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(resultMatrix);
