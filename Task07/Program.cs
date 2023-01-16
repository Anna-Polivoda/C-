// 7. Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99)
{
    int res = num % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Введено некоректное значение");
}
