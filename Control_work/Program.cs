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