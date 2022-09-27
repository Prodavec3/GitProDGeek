int a = 12;
Console.WriteLine(a.GetType());
Console.WriteLine(a.GetTypeCode());

/* Антипаттерны - магические числа (числа, которые непонятно почему подставлены) без какой-либо логики
 * 
 * Используем константы, например, String.Empty вместо ""*/

// Задача увеличить координаты в 2 раза

string text = "(1,2) (3,4) (5,6) (7,8)" // убираем скобки, они роли не будут играть как только мы сделаем парсинг по числам
              .Replace("(", "")
              .Replace(")", "");

var data = text.Split(" ")
               .Select(item => item.Split(",")) // Выбираем значение по разделителю
               .Select(e => (int.Parse(e[0]), int.Parse(e[1]))) // Массив кортежей (int, int), вывод делать WriteLine(data[i]), без этой строки был массив
               .ToArray(); // Разбиение строки с учетом разделителя



for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);

    /*for (int j = 0; j < data[i].Length; j++)
    {
        Console.WriteLine(data[i][j]);
    }*/
}