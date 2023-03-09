//Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число ");
string S = Console.ReadLine();

if (S.Length != 5)
{
    Console.Write("Вы ввели не пятизначное число");
}
else
{
    Palindrom(S);
}

void Palindrom(string S)
{
int N = 0;
    for(int i = 0, j = 4; i < 3; i++, j--)
    {
        if(S[i] != S[j])
        {
            N = 1;
            Console.Write("Число не палиндром");
            break;
        }
    }
    if(N == 0)
    {
     Console.Write("Число палиндром");   
    }
}
