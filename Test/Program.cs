
void CreateSecondArray(string[] fArray, string[] sArray)
{
    int count = 0;
    for (int i = 0; i < fArray.Length; i++)
    {
    if(fArray[i].Length <= fArray.Length)
        {
        sArray[count] = fArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
string[] firstArray = new string[5] {"Oslo", "Quebec", "Seoul", "Mockow", "Dubai"};
string[] secondArray = new string[3];

CreateSecondArray(firstArray, secondArray);
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);