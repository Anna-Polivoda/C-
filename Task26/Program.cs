// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
//if(int.TryParse(Console.ReadLine(), out number));
// else Console.WriteLine ("Введено некорректное значение. Введите целое число");

int countNumber = CountNumber(number);
Console.WriteLine($"{number} -> {countNumber}");

int CountNumber(int num)
{
    num = Math.Abs(num);
    //if (num < 0) num = num * -1;
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}