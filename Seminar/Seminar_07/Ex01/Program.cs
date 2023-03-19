//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

int m = GetNumber("Введите количество строк в массиве: ");
int n = GetNumber("Введите количество столбцов в массиве: ");
Console.WriteLine();

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine("Двумерный массив: ");
PrintArray(matrix);
