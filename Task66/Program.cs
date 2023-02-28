// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (SumNumbers(M, N));

int SumNumbers(int n, int m)
{
    if (m < n) return (n+SumNumbers(n - 1, m));
    else if (m > n) return (m + SumNumbers(m - 1, n));
    else return n;
}

