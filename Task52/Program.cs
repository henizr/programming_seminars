int[,] mtrx = CreateMatrix(3, 4, 1, 10);
PrintMatrix(mtrx);
double[] arr = GetArithmeticMean(mtrx);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arr);

double[] GetArithmeticMean(int[,] matrix)
{
    double[] resultArray = new double[matrix.GetLength(1)];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        double total = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            total += matrix[i, j];
        }
        resultArray[j] = Math.Round(total / matrix.GetLength(0), 1, MidpointRounding.ToZero);
         
    }
    return resultArray;
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
void PrintArray(double[] array)
{
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ", 5);
        }
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
