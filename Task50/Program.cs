int[,] mtrx = CreateMatrix(3, 4, 1, 10);
PrintMatrix(mtrx);

Console.WriteLine("Введите ряд: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

GetElement(mtrx, row, column);

void GetElement(int[,] matrix, int x, int y)
{

    if(x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1))
    {
        Console.WriteLine($"{x},{y} -> {matrix[x,y]}");
    }
    else
    {
        Console.WriteLine($"{x},{y} -> такого элемента в массиве нет");
    }
}

int[,] CreateMatrix(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max+1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]} ", 5);
            }
            Console.WriteLine();
        }
}
