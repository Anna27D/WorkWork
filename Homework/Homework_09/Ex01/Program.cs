// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int ShowNumbersRec(int N, int i)
{
    if (N == i) return N;
    else Console.Write($"{ShowNumbersRec(N, i + 1)}, ");
    return i;
}

Console.WriteLine();
int N = GetNumber("Введите число больше 1: ");
Console.WriteLine();
int i = 1;
if (N < 1) Console.WriteLine("Нужно ввести число больше 1.");
else
{
    Console.WriteLine(ShowNumbersRec(N, i));
}
Console.WriteLine();
