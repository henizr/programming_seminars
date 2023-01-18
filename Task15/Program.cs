bool isDayOff(int dayNum)
{
    return dayNum == 6 || dayNum == 7;
}

Console.Write("Введите номер дня: ");
int day = Convert.ToInt32(Console.ReadLine());

if(isDayOff(day))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
