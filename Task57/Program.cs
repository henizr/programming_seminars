int[,] mtrx = CreateMatrix(4, 4, 1, 10);
PrintMatrix(mtrx);
Console.WriteLine();
int[] array = MatrixToArray(mtrx); 
Print(array);
Console.WriteLine();
GetSameCountNumber(array); 

void GetSameCountNumber(int[] arr)
{
    int tmp = arr[0];
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == tmp)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{tmp} -> {count}");
            tmp = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{tmp} -> {count}");
}

int[] MatrixToArray(int[,] array)
{
    int[] arr = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[count++] = array[i,j];
        }
    }
    Array.Sort(arr);
    return arr;
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
void Print(int[] array)
{
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
}