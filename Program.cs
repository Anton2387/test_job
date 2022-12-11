

string[] array = new string[5]{ "23", "hello", "d34", "friends", "qwerty"};
Console.WriteLine("First");
PrintArray(array);

Console.WriteLine();

string[] newArray = new string[array.Length];
Console.WriteLine("Second");
NewArray(array, newArray);
PrintArray(newArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void NewArray(string[] array, string[] newArray)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 )
        {
            newArray[i] = array[i];
        }
    }
}