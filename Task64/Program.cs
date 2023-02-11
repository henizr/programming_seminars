Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (N > 0)
{
    Console.Write($"N={N} -> ");
    ShowNumbers(N);
}
else{
    Console.WriteLine("Число не натуральное");
}


void ShowNumbers(int n)
{
    if(n == 0) return;
    Console.Write($"{n} ");
    ShowNumbers(n-1);   
}
