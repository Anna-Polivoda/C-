// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] genArray = CreateArrayRndInt(10, 0, 255);
PrintArray(genArray);
Console.WriteLine();
int[] newArray = CopyArray (genArray);
newArray[3] = -1;
PrintArray(newArray);

int[] CopyArray (int[] mass)
{
    int[] newArray = new int[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        newArray[i] = mass[i];
    }
    return newArray;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());

// Fibonacci(number);
// void Fibonacci (int num)
// {
// int first = 0, second = 1;
// Console.Write($"Если N = {number} -> {first} {second} ");
// for (int i = 2; i < number; i++)
// {
// int newNumber = first + second;
// Console.Write($"{newNumber} ");
// first = second;
// second = newNumber;
// }
// }