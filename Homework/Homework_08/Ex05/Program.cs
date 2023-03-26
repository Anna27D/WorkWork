// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] Array)
{
    int Count = 1;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            while (Count <= Array.GetLength(0) * Array.GetLength(1))
            {
                Array[i, j] = Count;
                Count++;
                if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= Array.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > Array.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = 4;
int[,] Array = new int[m, m];

Console.WriteLine();
FillArray(Array);
Console.WriteLine("Спирально заполненный массив: ");
PrintArray(Array);
