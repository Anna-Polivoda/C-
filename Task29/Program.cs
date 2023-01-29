// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, -> [1, 2, 5, 7,19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = CreateArray(8);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = num.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
