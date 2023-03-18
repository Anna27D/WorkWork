//Напишите программу, которая принимает на вход три числа
//и проверяет, может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: Каждая сторона треугольника меньше суммы двух других сторон.

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

void CheckSides(int SideA, int SideB, int SideC)
{
    int Sum = 0;
    Sum = SideA + SideB;
    if (Sum > SideC)
    {
        Console.WriteLine("Такой треугольник существует");
    }
    else
    {
        Console.WriteLine("Такой треугольник не существует");
    }

}

int SideA = GetNumber("Введите первое число ");
int SideB = GetNumber("Введите второе число ");
int SideC = GetNumber("Введите третье число ");

CheckSides(SideA, SideB, SideC);
