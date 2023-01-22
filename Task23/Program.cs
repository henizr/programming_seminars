Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Некорректный ввод");
}
else
{
    GetCubeTable(num);
}

void GetCubeTable(int number)
{
    int i = 1;
    while(i<=number)
    {
        Console.WriteLine($"{i} -> {i*i*i}");
        i++;
    }
}