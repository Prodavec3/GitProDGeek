int[] array = { 123, 51, 6433, 231, 123, 35635, 123};
int max = array[0];
for (var i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);

// либо
foreach (int i in array)
{
    if (i > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);