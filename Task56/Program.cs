// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumElement = SumElementRow(matrix);
int numberRowMinSum = NumberRowMinSum(sumElement);
Console.WriteLine($"Номер строки с минимальной суммой элементов = {numberRowMinSum + 1}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumElementRow(int[,] matrix)
{
    int[] sumElement = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumElement[i] = sum;
    }
    return sumElement;
}

int NumberRowMinSum(int[] arr)
{
    int min = arr[0];
    int numberRow=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) 
        {
            min = arr[i];
            numberRow = i;
    }
    }
    return numberRow;
}
