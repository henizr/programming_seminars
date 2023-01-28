double[] arr = GenerateArray(3, 10, 50);   
double result = Math.Round((Max(arr) - Min(arr)), 1, MidpointRounding.ToZero);
Console.WriteLine(GetArrayInStr(arr) + " -> " + result.ToString());

double[] GenerateArray(int size, double min, double max)
{
    Random rnd = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        double newRandomValue = rnd.NextDouble() * (max-min) + min;
        array[i] = Math.Round(newRandomValue, 1, MidpointRounding.ToZero);
    }
    return array; 
}
double Min(double[] array)
{
    double minValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    return minValue;
}
double Max(double[] array)
{
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}
string GetArrayInStr(double[] array)
{
    string str = string.Empty;
    str += "[";
    for (int i = 0; i < array.Length; i++)
    {
        str += $"{array[i]}";
        if(i != array.Length-1)
        {
            str += ", ";
        }
    }
    str += "]";
    return str;
}


