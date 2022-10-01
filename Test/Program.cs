string[] array = {"example", "fin", "test", "5" };

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if(array[j].Length <= 3)
    {
        Console.Write($"{array[j]} ");
    }
}