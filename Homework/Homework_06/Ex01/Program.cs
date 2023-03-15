//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Check(NumberA);

void Check(int NumberA)
{
    int Var = 0;
    int Count = 0;
    for (int i = 0; i < NumberA; i++)
    {
        Console.Write("Введите число ");
        Var = Convert.ToInt32(Console.ReadLine());
        if (Var > 0)
        {
            Count++;
        }
    }
    Console.WriteLine();
    Console.Write($"Количество чисел больше 0: {Count}.");
}
