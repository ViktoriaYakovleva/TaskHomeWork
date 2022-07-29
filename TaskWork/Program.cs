string[] FirstArray = new string[5] {"mother", "sun", "3", "and", "hello"};
string[] SecondArray = new string [FirstArray.Length];

void NewArray (string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[count] = FirstArray[i];
            count++;
        }
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(FirstArray, SecondArray);
PrintArray(SecondArray);