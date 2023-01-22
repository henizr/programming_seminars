Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 10000 || num > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{
 if(IsPalindrom(num))
 {
    Console.WriteLine("Да");
 }
 else
 {
    Console.WriteLine("Нет");
 }
}


bool IsPalindrom(int number)
{
    int firstNum = number / 1000;
    int secondNum = number % 100;
    int flippedSecondNum = (secondNum / 10) + (secondNum % 10) * 10;

    if (firstNum == flippedSecondNum){
        return true;
    }
    return false;
}

