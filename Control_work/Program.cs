string [] CountingSymbolsInArrayString(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string [] arr = new string[count];
    return arr;
}

string [] NewArrayStringLess3 (string [] array, string [] arr)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}