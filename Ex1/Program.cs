//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ и выдаёт номер четверти плоскости, в которой находится эта точка.
int FindQuarter (int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
    return 0;
}
Console.WriteLine (FindQuarter(1 , 2));
