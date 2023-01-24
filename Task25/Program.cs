﻿Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree > 0)
{
    int res = Pow(number, degree);
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Введена некорректная степень");
}



int Pow(int num, int deg)
{
    int result = 1;
    while (deg > 0)
    {
        result *= num;
        deg--;
    }
    return result;
}