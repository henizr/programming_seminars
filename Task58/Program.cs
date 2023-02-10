int[,] mtrx1 = CreateMatrix(2, 2, 1, 9);
int[,] mtrx2 = CreateMatrix(2, 2, 1, 9);
PrintMatrix(mtrx1);
Console.WriteLine();
PrintMatrix(mtrx2);
Console.WriteLine();

if(mtrx1.GetLength(1) == mtrx2.GetLength(0))
{
     int [,] mtrx = MultiplyMatrix(mtrx1, mtrx2);
     PrintMatrix(mtrx);
}
else
{
    Console.WriteLine("Невозможно перемножить матрицы");
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultArray = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    int total = 0;
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            total += matrix1[i,j] * matrix2[j,i];
            resultArray[i,j] = total;
        }   
        total = 0;
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

void PrintMatrix(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}  |", 20);
            }
            Console.WriteLine();
        }
}