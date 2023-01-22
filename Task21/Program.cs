Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: {distance}");


double GetDistance(int a1, int b1, int c1, int a2, int b2, int c2){
    double result = Math.Sqrt(Math.Pow(a2-a1, 2) + Math.Pow(b2-b1, 2) + Math.Pow(c2-c1, 2) );
    result = Math.Round(result, 2, MidpointRounding.ToZero);
    return result;
}
