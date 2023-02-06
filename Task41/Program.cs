// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[]array = CreateArray (size);
int result = CountPositive(array);
Console.WriteLine($"Количество чисел больше нуля: {result}");

int[] CreateArray (int size)
{
    int[]arr=new int [size];
    for (int i = 0; i < size; i++)
    {
     Console.Write($"Введите число: ");
     arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountPositive(int[]arr)
{
    int count=0;
    for (int i = 0; i < size; i++)
    {
       if (arr[i]>0) count++;
    }
return count;
}