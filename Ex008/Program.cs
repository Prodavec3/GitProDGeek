void AddArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] collectionPrint)
{
    for (var i = 0; i < collectionPrint.Length; i++)
    {
        Console.WriteLine(collectionPrint[i].ToString());
    }
}

int[] array = new int[10]; // 10 элементов в массиве определили, наполнен 0

AddArray(array);
PrintArray(array);