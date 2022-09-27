int a = 12;
Console.WriteLine(a.GetType());
Console.WriteLine(a.GetTypeCode());

/* Антипаттерны - магические числа (числа, которые непонятно почему подставлены) без какой-либо логики
 * 
 * Используем константы, например, String.Empty вместо ""*/

// Задача увеличить координаты в 2 раза

string text = "(1,2) (2,5) (3,4) (4,6) (5,6) (7,8)" // убираем скобки, они роли не будут играть как только мы сделаем парсинг по числам
              .Replace("(", "")
              .Replace(")", "");

var data = text.Split(" ")
               .Select(item => item.Split(",")) // Выбираем значение по разделителю
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // Массив кортежей (int, int), вывод делать WriteLine(data[i]), без этой строки был массив
               // x и y назвали данные значения, потом с ними можно будет работать 
               .Where(e => e.x % 2 == 0) // можно сделать выборку по условию, если координата х делится на 2
               .Select(point => (point.x * 10, point.y))
               .ToArray(); // Разбиение строки с учетом разделителя



for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    //Console.WriteLine(data[i].x * data[i].y); // можем производить операции с Item кортежа

    /*for (int j = 0; j < data[i].Length; j++)
    {
        Console.WriteLine(data[i][j]);
    }*/
}