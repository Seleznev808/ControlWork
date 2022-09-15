int CountingSymbolsInArrayString(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
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

string [] array = new string [4] {"hello", "2", "world", ":-)"};
int lengthArray = CountingSymbolsInArrayString(array);
string [] arrayNew = new string [lengthArray];
arrayNew = NewArrayStringLess3(array, arrayNew);
PrintArray(arrayNew);