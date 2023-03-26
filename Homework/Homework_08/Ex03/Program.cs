// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int SumElement = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                SumElement = SumElement + firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = SumElement;
        }
    }
}

int m = GetNumber("Введите количество строк: ");
int g = m;
int n = GetNumber("Введите количество столбцов: ");
int l = n;
Console.WriteLine();

int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[l, g];
int[,] resultMatrix = new int[m, g];

FillArray(firstMatrix);
Console.WriteLine("Первая матрица: ");
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintArray(secondMatrix);
Console.WriteLine();
MatrixMultiplication(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(resultMatrix);
