int p = Pow(2, 3);
Console.WriteLine(p);


int Pow(int a, int b)
{
    if(b==0) return 1;
    return Pow(a, b-1) * a;
}
