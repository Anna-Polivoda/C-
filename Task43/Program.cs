// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1==k2 && b1==b2)
 {
    Console.WriteLine($"Прямые совпадают");
 }
else if (k1==k2)
{
 Console.WriteLine($"Прямые не пересекаются");
}
else 
{
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.Write($"Точка пересечения двух прямых: ({Math.Round(x,1)},{Math.Round(y,1)})");
}

// к сожалению не поняла куда здесь вставить метод, но я пыталась
// double meaningXY= []Array (k1,b1,k2,b2);
// if (k1==k2 && b1==b2)
//  {
//     Console.WriteLine($"Прямые совпадают");
//  }
// else if (k1==k2)
// {
//  Console.WriteLine($"Прямые не пересекаются");
// }
// Console.Write($"Точка пересечения двух прямых: {meaningXY}");

// double []Array (int K1, int B1, int K2, int B2)
// {
// double []arr =new double();
// arr[x]=(B2-B1)/(K1-K2);
// arr[y]=K1*arr[x]+B1;
// double xRound= Math.Round(arr[x],1);
// double yRound = Math.Round(arr[y],1);
// return arr;
// }


