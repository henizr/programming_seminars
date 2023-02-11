Console.WriteLine("m: ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("n: ");
int N = Convert.ToInt32(Console.ReadLine());

int a = A(M,N);

Console.WriteLine($"m = {M}, n = {N} -> A(m,n) = {a}");

int A(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if(m == 0)
    {
       return A(n-1, 1);
    }
    else
    {
        return A(n-1, A(n, m-1));
    }
}
