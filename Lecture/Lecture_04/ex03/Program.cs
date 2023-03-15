//Метод, который находит простой факториал.
double Factorial(int n) //Если заменить int на double, значения будут отображаться корректно.

{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(3)); //3! = 1*2*3 = 6

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
