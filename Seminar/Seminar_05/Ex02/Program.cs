//Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[5];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.WriteLine(array[i]);
    }
}

void Change(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            array[i] = Math.Abs(array[i]);
        }
        else
        {
            array[i] = 0 - array[i];
        }
        Console.WriteLine(array[i]);
    }
}

FillArray(array);
Console.WriteLine();
Change(array);
