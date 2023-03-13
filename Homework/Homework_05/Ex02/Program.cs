//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[5];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.WriteLine(array[i]);
    }
}

void SumArray(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            Sum = Sum + array[i];
        }
    }
    Console.Write(Sum);
}

FillArray(array);
Console.WriteLine();
Console.Write("Сумма элементов, стоящих на нечетных позициях: ");
SumArray(array);
