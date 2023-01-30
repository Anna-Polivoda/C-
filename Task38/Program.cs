// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[]array=CreateArrayRndDouble(5, 0, 99);
PrintArrayDouble(array);
double maxElement =MaxElement(array);
double minElement=MinElement(array);
Console.WriteLine();
Difference(maxElement, maxElement);

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {   
        arr[i]= rnd.NextDouble()*(max-min)+min;  
    }
    return arr;
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i],1)}, ");
        else Console.Write($"{Math.Round(arr[i],1)}");
    }
    Console.Write("]");
}

double MaxElement(double[]arr)
{ double max=arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (max<arr[i]) return max = arr[i];
}
return max;
}

double MinElement(double[]arr)
{ double min=arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (min>arr[i]) return min = arr[i];
}
return min;
}

void Difference(double min, double max)
{
double result = maxElement-minElement;
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива = {Math.Round(result,1)}");
}