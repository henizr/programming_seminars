Console.WriteLine("Сколько Вы хотите ввести чисел?");
int numCount = Convert.ToInt32(Console.ReadLine());
int[] numbersFromUser = GetNumbersFromUser(numCount);
int numbersAmountGreaterThanZero = GetNumbersAmountGreaterThanZero(numbersFromUser);
string result =  GetArrayInStr(numbersFromUser) + " -> " + numbersAmountGreaterThanZero.ToString();
Console.WriteLine(result);

int[] GetNumbersFromUser(int count)
{
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write("-> ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

int GetNumbersAmountGreaterThanZero(int[] array)
{
    int counter=0;
    int i = 0;
    while(i < array.Length)
    {
        if(array[i] > 0)
        {
            counter++;
        }
        i++;
    }
    return counter;
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