Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(num); 
Console.WriteLine($"Сумма цифр числа равна: {sum}");


int SumDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        int lastDigit = number % 10;
        sum += lastDigit;
        number = number / 10; 
        if(number < 10)
        {
            sum += number;
            break;
        }
    }
    return sum;
}