//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[12];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.WriteLine(array[i]);
    }
}

void SumPos(int[] array)
{
    int SumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            SumPos = SumPos + array[i];
        }
    }
    Console.Write(SumPos);
}

void SumNeg(int[] array)
{
    int SumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            SumNeg = SumNeg + array[i];
        }
    }
    Console.Write(SumNeg);
}

FillArray(array);
Console.WriteLine();
Console.Write("Сумма положительных элементов массива: ");
SumPos(array);
Console.WriteLine();
Console.Write("Сумма отрицательных элементов массива: ");
SumNeg(array);
