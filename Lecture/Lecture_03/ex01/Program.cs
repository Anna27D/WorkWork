//Вид1

void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1();


//Вид2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения"); //Method2("Текст сообщения");

//2.1

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); //Method21("Текст", 4); //Method21(count: 4, msg: "Текст");


//Вид3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


//Вид4

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);


//Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}


//Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "c".

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char OldValue, char NewValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(text, 'к', 'К');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Replace(text, 'С', 'с');
Console.WriteLine(NewText);

