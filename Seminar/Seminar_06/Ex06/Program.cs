//Напишите программу сложения двух матриц.
//теория + проверить https://yotx.ru/Матрицы/Сложение

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

void MatrixSum(int[,] matrix, int[,] matrix2, int[,] Sum)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum[i, j] = matrix[i, j] + matrix2[i, j];
        }
    }
}

int[,] matrix = new int[3, 4];
int[,] matrix2 = new int[3, 4];
int[,] Sum = new int[3, 4];

FillArray(matrix);
FillArray(matrix2);
Console.WriteLine();
Console.WriteLine("Первая матрица: ");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);
Console.WriteLine();
MatrixSum(matrix, matrix2, Sum);
Console.WriteLine("Сумма двух матриц: ");
PrintArray(Sum);
