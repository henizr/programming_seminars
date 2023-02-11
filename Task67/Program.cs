// 45 -> 12
Convert(45);
Console.WriteLine(SumNum(45));
 

void Convert(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum += num%10;
        num /= 10;
    }

    Console.WriteLine(sum);
}

int SumNum(int num)
{
    if(num == 0) return 0;
    return SumNum(num/10) + num%10;
}