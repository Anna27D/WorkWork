//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverage(int[,] matrix, double[] Average)
{
    int g = 0;
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int S = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            S = S + matrix[i, j];
        }
        Average[g] = ((double)S / matrix.GetLength(0));
        Console.Write($"{Average[g]:0.##}; ");
        g++;
    }
}

int m = GetNumber("Введите количество строк в массиве: ");
int n = GetNumber("Введите количество столбцов в массиве: ");
Console.WriteLine();

int[,] matrix = new int[m, n];
double[] Average = new double[n];

FillArray(matrix);
Console.WriteLine("Массив: ");
PrintArray(matrix);
Console.WriteLine();
FindAverage(matrix, Average);
