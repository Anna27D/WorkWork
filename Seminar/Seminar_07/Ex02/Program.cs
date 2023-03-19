//Задайте двумерный массив.
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void ChangeElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
                }
        }
    }
}

int m = GetNumber("Введите количество строк в массиве: ");
int n = GetNumber("Введите количество столбцов в массиве: ");
Console.WriteLine();

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine("Начальный массив: ");
PrintArray(matrix);
Console.WriteLine();
ChangeElements(matrix);
Console.WriteLine("Новый массив: ");
PrintArray(matrix);
