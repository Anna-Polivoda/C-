// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");

int maxDigit= MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = number / 10; // 7
    int secondDigit = number % 10; // 8
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return 0;
}
