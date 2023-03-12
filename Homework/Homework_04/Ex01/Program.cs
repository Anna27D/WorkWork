//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите первое число ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int NumberB = Convert.ToInt32(Console.ReadLine());

Rate();

void Rate()
{
    double Result = 0;
    Result = Math.Pow(NumberA, NumberB);
    Console.Write(Result);
}

//int Rate(int NumberA, int NumberB)
//{
//int Result = 0;
//return Result = Convert.ToInt32(Math.Pow(NumberA, NumberB));
//Console.Write(Result);
//}
//
//int Result = Rate(NumberA, NumberB);
//Console.Write(Result);
