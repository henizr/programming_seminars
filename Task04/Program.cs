int max = 0;
Console.WriteLine("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int numThree = Convert.ToInt32(Console.ReadLine());

max = numOne;

if (numTwo > max){
    max = numTwo;
}
if(numThree > max){
    max = numThree;
}

Console.Write($"Максимальное число: {max}");