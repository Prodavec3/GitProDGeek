void AddArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
    collection[2] = 5;
    collection[9] = 5;
}

void PrintArray(int[] collectionPrint)
{
    for (var i = 0; i < collectionPrint.Length; i++)
    {
        Console.WriteLine(collectionPrint[i].ToString());
    }
}

void IndexOf(int[] collectionFindIndex, int find)
{
    bool founded = false;
    for (var i = 0; i < collectionFindIndex.Length; i++)
    {
        if (collectionFindIndex[i] == find)
        {
            Console.WriteLine("Число: " + find + " находится на ближайшей к началу позиции - " + i);
            founded = true;
            break;
        }
    }
    if (!founded)
    {
        Console.WriteLine("Такого числа в массиве не найдено");
    }
}

int[] array = new int[10]; // 10 элементов в массиве определили, наполнен 0

AddArray(array);
PrintArray(array);
IndexOf(array, 5);