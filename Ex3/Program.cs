// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

double FindDistance (double x1, double x2, double y1, double y2)
{
    double d = Math.Sqrt ((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1));
        return d;
}
Console.WriteLine (FindDistance(3, 2, 6, 1));