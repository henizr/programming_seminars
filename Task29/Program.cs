int[] newArray = GenerateArray(1,5);
PrintArray(newArray);

int[] GenerateArray(int minValue, int maxValue)
{
    int[] array = new int[8];
    int index = 0;
    Random rnd = new Random();
    while(index < array.Length)
    {
        array[index] = rnd.Next(minValue, maxValue+1);
        index++;
    }
    return array;
}
void PrintArray(int[] array)
{
    string str = String.Empty;
    str += "[";
    for(int i = 0; i < array.Length; i++)
    {
        str += $"{array[i]}";
        if(i != array.Length-1)
        {
            str += ", ";
        }
    }
    str += "]";
    Console.Write(str);
}
