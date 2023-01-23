// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
double distanceRound =Math.Round(distance,2,MidpointRounding.ToZero);
Console.WriteLine(distanceRound);

double Distance(int xa, int ya, int xb, int yb)
{
    int cat1 = xa - xb;
    int cat2 = ya - yb;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return result;
}