/* Игра пирамидки, есть несколько осей - с одной на какую-то определенную нужно переложить пирамидку
 * with - откуда перекладываем, on - где должен оказаться
 * some - промежуточный, count - количество блинов */
Console.WriteLine("Задача про пирамидки");
void Towers(string with = "1", string on = "3", 
            string some = "2", int count = 3)
{
    if (count > 1) Towers(with,some,on,count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
Console.WriteLine("");
/* Обход разных структур - одномерный массив строк */
Console.WriteLine("Обход, рекурсия");
string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp,
                "4", "2", "1", "3"};
/*  нумерация узлов, (4-2) * (1 + 3) / 10 
 *    /      1
 *  * 10     23
 *  - +      45
 *  4 2      89
 *  1 3      1011
 *  т.е дерево узлов строится, слева 2*(узел), справа 2*(узел-1)
 */
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2*pos; // позиция леового поддерева
        int right = 2*pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); /* если левое поддерево имеется 
                                                                                              * и элемент не пустой который там хранится, 
                                                                                              * то рекурсивно запускаем обход с этой позицией */
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();