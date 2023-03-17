//Написать программу, которая на вход получает массив,
//а на выходе собирает новый массив только из чисел, кратных 5.

//метод создания массива
//метод заполнения массива
//метод подсчета чисел, кратных 5
//решение задачи
//печать

int[] arr = { 2, 5, 6, 10, 32, 30 };

int count = 0;
int index;
index = 0;

while (index < arr.Length)
{
    if (arr[index] % 5 == 0)
    {
        count++;
    }
    index++;
}

int[] arrNew = new int[count];
index = 0;
int indexNew = 0;

while (index < arr.Length)
{
    if (arr[index] % 5 == 0)
    {
        arrNew[indexNew] = arr[index];
        indexNew++;
    }
    index++;
}

Console.WriteLine(arrNew);
index = 0;

while (index < arrNew.Length)
{
    Console.WriteLine(arrNew[index]);
    index++;
}
