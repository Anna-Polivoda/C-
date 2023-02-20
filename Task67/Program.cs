// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10)); // 3628800

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumnumbers = SumNumbers(num);

Console.WriteLine($"Сумма чисел равна {sumnumbers}");

int SumNumbers(int number)
{
if (number == 0) return 0;
return number%10 + SumNumbers(number/10);
}