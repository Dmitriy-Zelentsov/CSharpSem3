//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void FindRange (int number)
{
    if (number == 1)
         Console.WriteLine("x > 0 и y > 0");
    else if (number == 2)
         Console.WriteLine("x < 0 и y > 0");
    else if (number == 3)
         Console.WriteLine("x < 0 и y < 0");
    else if (number == 4)
         Console.WriteLine("x > 0 и y < 0");
    else
     Console.WriteLine("Такой области нет");
}

