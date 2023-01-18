int GetSecondDigit(int num)
{
    int result = (num % 100) / 10;
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = GetSecondDigit(number);
Console.WriteLine(secondDigit);

