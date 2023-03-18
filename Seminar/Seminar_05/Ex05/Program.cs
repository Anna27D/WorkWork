//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.Write("Введите количество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = new int[count];
int[] NewArray = new int[count / 2];

void FillArray(int[] array, int count)
{
    for (int i = 0; i < count; i++)
    {

        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }

}

void Pairs(int[] array, int[] NewArray)
{

    for (int i = 0; i < array.Length / 2; i++)
    {
        NewArray[i] = array[i] * array[array.Length - 1 - i];
        Console.Write($"{NewArray[i]} ");
    }
    if (array.Length % 2 != 0)
    {
        NewArray[NewArray.Length - 1] = array[array.Length / 2];
        Console.Write(NewArray[NewArray.Length - 1]);
    }
}

Console.WriteLine();
FillArray(array, count);
Console.WriteLine();
Console.WriteLine();
Pairs(array, NewArray);
Console.WriteLine();
