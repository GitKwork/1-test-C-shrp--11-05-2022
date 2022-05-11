string[] FillArray()
{
    Console.WriteLine("Enter any strings separated by ',' and/or ' ': ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] Array = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return Array;
}
string PrintArray(string[] Array)
{
    string stringArray = "[";
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
        {
            stringArray += $"\"{Array[i]}\"";
            break;
        }
        stringArray += ($"\"{Array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}
int CountSymTo3(string[] Array)
{
    int counter = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
string[] CreateNewArray(string[] Array)
{
    int resultArrayLength = CountSymTo3(Array);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}
string[] Array = FillArray();
string[] resultArray = CreateNewArray(Array);
string firstArray = PrintArray(Array);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);