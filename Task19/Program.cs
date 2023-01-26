// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);

void Palindrom(int number)
{
    if (number >= 10000 && number < 100000)
    {
        int n1 = number / 10000;
        int n5 = number % 10;
        if (n1 == n5)
        {
            int n2 = number / 1000 % 10;
            int n4 = number / 10 % 10;
            if (n2 == n4)
                Console.WriteLine("Палиндром");
        }
        else Console.WriteLine("Не палиндром");

    }
    else Console.WriteLine("Некорректное число");
}
