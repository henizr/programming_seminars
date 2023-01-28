int[] arr = GenerateArray(4, 100, 999);
string arrInStr = GetArrayInStr(arr);
int sumEvenNum = GetSumEvenNum(arr);
Console.WriteLine(arrInStr + " -> " + sumEvenNum.ToString());

int[] GenerateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < size; i ++)
    {
        array[i] = rnd.Next(min, max+1);
    }

    return array;
}

int GetSumEvenNum(int[] array)
{
    int total = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            total += 1;
        }
    }
    return total;
}

string GetArrayInStr(int[] array)
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
