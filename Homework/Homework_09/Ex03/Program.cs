// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Console.WriteLine();
int m = GetNumber("Введите неотрицательное число m: ");
int n = GetNumber("Введите неотрицательное число n: ");
Console.WriteLine();
if (m < 0 || n < 0) Console.WriteLine("Одно из введенных чисел отрицательное.");
else
{
    Console.WriteLine($"A ({m}, {n}) = {AkkermanFunction(m, n)}");
}
Console.WriteLine();
