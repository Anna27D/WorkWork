// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

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
            matrix[i, j] = new Random().Next(0, 10);
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

void Sum(int[,] matrix)
{
    int Sum = 0;
    int SumIndex = 0;
    int min;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        Sum = Sum + matrix[0, j];
    }
    min = Sum;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum = Sum + matrix[i, j];
        }
        Console.WriteLine($"Сумма {i} строки: {Sum}.");
        if (Sum < min)
        {
            SumIndex = i;
            min = Sum;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SumIndex}.");
}

int m = GetNumber("Введите количество строк и столбцов в массиве: ");
Console.WriteLine();

int[,] matrix = new int[m, m];

FillArray(matrix);
Console.WriteLine("Массив: ");
PrintArray(matrix);
Console.WriteLine();
Sum(matrix);
