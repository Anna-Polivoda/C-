// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Пример:
// 2 3 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > num1)
     max = num2;
if (num3 > num2)
     max = num3;
Console.Write($"Максимальное число {max}");

