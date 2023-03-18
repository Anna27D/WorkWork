//Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.).
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

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

void Change(int[] array, int[] NewArray)
{

    for (int i = 0; i < array.Length; i++)
    {
        NewArray[i] = array[array.Length - 1 - i];
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
Change(array, NewArray);
Console.WriteLine();
