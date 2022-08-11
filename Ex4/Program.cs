// Напишите программу,которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до
//5 -> 1, 4, 9, 16, 25
//2 -> 1,4
int FindN (int n)
{
    int i=1;
    while(i < n)
    {
    Console.Write($"{i*i}, ");
    i++;
    }
    return n;
}
Console.Write(FindN(7));
