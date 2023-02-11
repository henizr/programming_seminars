ShowNumbers(4,10);


void ShowNumbers(int m, int n)
{
    Console.Write($"{m} ");
    if (n==m)
    {
        return;
    }
    ShowNumbers(m+1, n);
}
