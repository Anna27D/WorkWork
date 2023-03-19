//Алгоритм, позволяющий закрашивать замкнутые области.

int[,] pic = new int[1, 1]; //массив с картинкой

//Метод, который выводит картинку в двумерный массив.
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.WriteLine($" ");
            else Console.WriteLine($"+");
        }
        Console.WriteLine();
    }
}

PrintImage(pic);

//Метод, который закрашивает картинку.
void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

FillImage(13, 13);
PrintImage(pic);
