//Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке,
//первый элемент массива не может быть равен нулю.
//N=8 -> [1,0,1,1,0,1,0,0]
//N=3 -> [1,1,0]

Console.Write("Введите число ");
int countN = Convert.ToInt32(Console.ReadLine());

Massiv(countN);

void Massiv(int countN)
{
    int[] Massiv = new int[countN];
    Massiv[0] = 1;
    Console.Write(Massiv[0]);
for(int i = 1; i < countN; i++)
{
    Massiv[i] = new Random().Next(0, 2);
    Console.Write(Massiv[i]);
}
}
