Console.WriteLine("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Максимальное число: ");
if (numOne > numTwo)
{
    Console.WriteLine(numOne);
}
else{
    Console.WriteLine(numTwo);
}