int GetSecondDigit(int number)
{
    int result = (number % 100) / 10;
    return result;
}

int secondDigit = GetSecondDigit(456);
Console.WriteLine(secondDigit);

