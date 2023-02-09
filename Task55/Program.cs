int[,] mtrx = CreateMatrix(4, 4, 1, 10);
PrintMatrix(mtrx);
Console.WriteLine();
int[,] newMtrx = new int[,]{};
if(mtrx.GetLength(0) == mtrx.GetLength(1))
{
     newMtrx = Replace(mtrx);
}
else
{
    Console.WriteLine("Невозможно поменять строки на столбцы");
}
PrintMatrix(newMtrx);


int[,] Replace(int[,] matrix)
{
    int[,] m = new int[matrix.GetLength(0),  matrix.GetLength(1)];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
           m[j,i] = matrix[i,j];  
        }
    }
    return m;
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
                Console.Write($"{matrix[i,j]} ", 10);
            }
            Console.WriteLine();
        }
}

