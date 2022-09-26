// Упорядочивание элементов массива
// алгоритм сортировки методом выбора, выбор максимального, метод минимакса и тд, кто как называет
// берем первый элемент, ищем наименьший и меняем наименьший на место первого (меняем местами)
// потом берем второй элемент, ищем наименьший, меняем местами (1 элемент уже отсортирован, его не трогаем) и тд

int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPos])
            {
                minPos = j;
            }
        }
        int temporary = array[i]; // буферная переменная для сохранения значения в выбранной ячейке, туда пишем наименьшее из найденных
        array[i] = array[minPos]; // записываем наименьшее число из найденных в iую ячейку
        array[minPos] = temporary; // с буферной переменной пишем значение откуда забрали наименьшее число
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);