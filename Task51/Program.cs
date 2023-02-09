int[,] mtrx = CreateMatrix(3, 4, 1, 10);
PrintMatrix(mtrx);
int sum = GetSumDiagonal(mtrx);
Console.WriteLine(sum);


int GetSumDiagonal(int[,] matrix)
{
    int total = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        total += matrix[i,i];
    }
    return total;
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