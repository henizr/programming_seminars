double[,] mtrx = CreateMatrix(3, 4, -10, 10);
PrintMatrix(mtrx);

double[,] CreateMatrix(int row, int column, double min, double max)
{
    double[,] matrix = new double[row, column];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double newRandomValue = rnd.NextDouble() * (max-min) + min;
            matrix[i,j] = Math.Round(newRandomValue, 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
}
