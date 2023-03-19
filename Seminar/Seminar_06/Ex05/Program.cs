//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

void FillArray(int[] array, int count)
{
    for (int i = 0; i < count; i++)
    {

        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }

}

void CopyArray(int[] array, int[] NewArray)
{

    for (int i = 0; i < array.Length; i++)
    {
        NewArray[i] = array[i];
        Console.Write($"{NewArray[i]} ");
    }
}

int count = GetNumber("Введите количество элементов в массиве: ");
Console.WriteLine();

int[] array = new int[count];
int[] NewArray = new int[count];

Console.Write("Начальный массив: ");
FillArray(array, count);
Console.WriteLine();
Console.Write("Новый массив: ");
CopyArray(array, NewArray);
Console.WriteLine();
