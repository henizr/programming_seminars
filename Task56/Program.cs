int[,] mtrx = CreateMatrix(4, 4, 0,9);
PrintMatrix(mtrx);
Console.WriteLine();
int[] sumRowsArr = GetSumRows(mtrx);
int minValueIndex = GetMinValueIndex(sumRowsArr);

Console.WriteLine($"Наименьшая сумма элементов в строке № {minValueIndex + 1}");

int GetMinValueIndex(int[] array)
{
    int minMalue = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 1; j < array.Length; j++)
        {
            if(array[j] < minMalue)
            {
                minMalue = array[j];
                minIndex = j;
            }
        }
    }
    return minIndex;
}

int[] GetSumRows(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
        sum = 0;
    }
    return result;
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
                Console.Write($"{matrix[i,j]} |", 10);
            }
            Console.WriteLine();
        }
}

