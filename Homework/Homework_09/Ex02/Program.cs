// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int SumOfElementsRec(int M, int N)
{
    if (M == N) return N;
    else return N + SumOfElementsRec(M, N - 1);
}

Console.WriteLine();
int M = GetNumber("Введите число M: ");
int N = GetNumber("Введите число N: ");
Console.WriteLine();
if (M > N) Console.WriteLine("Число M должно быть меньше числа N.");
else
{
    Console.Write($"Сумма чисел от {M} до {N}: {SumOfElementsRec(M, N)}");
}
Console.WriteLine();
