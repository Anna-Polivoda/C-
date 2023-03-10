// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = Multiplicity(num);
Console.WriteLine(res ? "Да" : "Нет");

bool Multiplicity(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}