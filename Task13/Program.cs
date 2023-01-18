Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetDigitsCount(int num)
{
    int counter = 0;
    while(num !=0){
        num /= 10;
        counter ++;
    }
    return counter;
}

int LeaveThreeDigits(int num)
{
    int deletindNumCount = GetDigitsCount(num) - 3;
    for(int i = 0; i < deletindNumCount; i++)
    {
        num /= 10;
    }
    return num;
}

if (GetDigitsCount(number) >= 3)
{
    int result = LeaveThreeDigits(number) % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}