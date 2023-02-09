int[,] mtrx = CreateMatrix(3, 4, 1, 10);
PrintMatrix(mtrx);
Replace(mtrx);
Console.WriteLine();
PrintMatrix(mtrx);


void Replace(int[,] matrix)
{
    for(int i =0; i < matrix.GetLength(1); i++)
    {
        int temporary = matrix[0, i];
        matrix[0, i] =  matrix[matrix.GetLength(0)-1, i];  
        matrix[matrix.GetLength(0)-1, i] = temporary;
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