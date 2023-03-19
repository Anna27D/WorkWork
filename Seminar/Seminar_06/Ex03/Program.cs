//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

void Convert(int Number, int[] Array)
{
    int i = 0;
    int Extra = 0; // остаток от деления
    while (Number >= 1)
    {
        Extra = Number % 2;
        Array[i] = Extra;
        i++;
        Number = Number / 2;
    }
    for (i = (Array.Length - 1); i >= 0; i--)
    {
        Console.Write(Array[i]);
    }
}

int Number = GetNumber("Введите число: ");
Console.WriteLine();

int[] Array = new int[10];

Convert(Number, Array);
Console.WriteLine();
