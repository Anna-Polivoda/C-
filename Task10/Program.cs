// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <=999)
{
    int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {secondDigit}");
}
else
    Console.WriteLine("Число не трёхзначное");

int SecondDigit(int num)
{
    int resalt = num / 10 % 10;
    return resalt;
}
