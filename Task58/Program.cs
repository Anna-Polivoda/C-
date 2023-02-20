// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] A = CreateMatrixRndInt(2, 2
, 0, 5);
int[,] B = CreateMatrixRndInt(2, 2, 0, 5);
PrintMatrix(A);
Console.WriteLine();
PrintMatrix(B);
Console.WriteLine();

if (СheckMatrix(A, B) == true)
{
    int[,] multiplicationMatrix = MultiplicationMatrix(A, B);
    Console.WriteLine("Итоговая матрица:");
    PrintMatrix(multiplicationMatrix);
}
else
{
    Console.WriteLine("Невозможно найти произведение матриц");
}

bool СheckMatrix(int[,] arrayA, int[,] arrayB)
{
    return arrayA.GetLength(1) == arrayB.GetLength(0);
}

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

int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                int result = arrayA[i, k] * arrayB[k, j];
                sum += result;
            }
            arrayC[i, j] = sum;
        }
    }
    return arrayC;
}

