Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = GetX(b1, k1, b2, k2);
double y = GetY(k1, b1, x);

string result = $"Точка пересечения двух прямых -> ({x},{y})";
Console.WriteLine(result);

double GetX(double _b1, double _k1, double _b2, double _k2)
{
    return (_b2-_b1)/(_k1-_k2);
}

double GetY(double _k1, double _b1, double _x)
{
    return _k1*_x+_b1;
}