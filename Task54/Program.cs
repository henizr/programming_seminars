int[,] mtrx = CreateMatrix(4, 4, 0, 9);
PrintMatrix(mtrx);
Console.WriteLine();
SortRows(mtrx);
PrintMatrix(mtrx);

void SortRows(int[,] array)
{
    int[] arr = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[j] = array[i, j];
        }
        Sort(arr);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arr[j];
        }
    }
}

void Sort(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
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
                Console.Write($"{matrix[i,j]} |");
            }
            Console.WriteLine();
        }
}

