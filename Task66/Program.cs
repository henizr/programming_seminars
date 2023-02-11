Console.WriteLine("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int sum = default;

if(M > N)
{
    sum = Sum(N,M);
    Console.WriteLine($"n={N},m={M} -> {sum}");
}
else
{
    sum = Sum(M,N);
    Console.WriteLine($"m={M},n={N} -> {sum}");
}

int Sum(int m, int n)
{
    if (n==m) return m;
    return Sum(m, n-1) + n;
}
