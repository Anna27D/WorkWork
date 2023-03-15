//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[5];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.WriteLine(array[i]);
    }
}

int Number(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int Count = int.Parse(ReadInput);
    return Count;
}

void Check(int[] array, int Count)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Math.Abs(array[i]) == Count)
        {
            Console.Write("Да");
            break;
        }
        else if (i == array.Length - 1)
        {
            Console.Write("Нет");
        }
    }
}

FillArray(array);
Console.WriteLine();
int Count = Number("Введите число: ");
Check(array, Count);

//или

//bool Check(int[] array, int el)
//{
//    int size = array.Length;
//    for (int i = 0; i < size; i++)
//        if (array[i] == el) return true;
//    return false;
//}

//string PrintResult(int[] array, int el, bool exist)
//{
//  if (exist) return $"В массиве [{String.Join(' ', array)}] элемент {el} присутствует";
//    return $"В массиве элементов нет";
//}

//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int find = 1;
//bool c = Check(arr, find);
//Console.WriteLine(PrintResult(arr, find, c));
