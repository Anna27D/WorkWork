// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

void FillArray(int[,,] matrix3D)
{
    int[] Array = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int Count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(10, 100);
        Count = Array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (Array[i] == Array[j])
                {
                    Array[i] = new Random().Next(10, 100);
                    j = 0;
                    Count = Array[i];
                }
                Count = Array[i];
            }
        }
    }
    int index = 0;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = Array[index];
                index++;
            }
        }
    }
}

void PrintArrayIndex(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int m = GetNumber("Введите размер массива m: ");
int n = GetNumber("Введите размер массива n: ");
int g = GetNumber("Введите размер массива g: ");
Console.WriteLine();

int[,,] matrix3D = new int[m, n, g];

FillArray(matrix3D);
Console.WriteLine("Трехмерный массив: ");
PrintArrayIndex(matrix3D);
Console.WriteLine();
