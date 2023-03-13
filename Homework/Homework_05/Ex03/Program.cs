//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 75

double[] array = new double[5];

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.WriteLine(array[i]);
    }
}

void Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    double Diff = 0;
    Diff = max - min;
    Console.Write($"{max} - {min} = ");
    Console.WriteLine(Diff);
}

FillArray(array);
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Difference(array);
