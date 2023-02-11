ShowNumbers(5);


void ShowNumbers(int n)
{
    if (n==0)
    {
        return;
    } 
    ShowNumbers(n-1);
    Console.Write($"{n} ");
}
