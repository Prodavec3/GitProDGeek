using System;
using System.Linq;
using System.Text;
using System.Net.Http;

class Program
{
    static public void Main(string[] args) /* args это 
        аргументы при .exe'шнике*/
    {
        if(args.Length >= 0) // если что-то есть
        {
            Console.WriteLine($"Hello. {args[0].Replace("-", "")}");
            /* и, допустим, дадим exe файлу какую-либо команду
             * bin\Debug\net6.0\ConsoleVS.exe, 
             * создаем его ярлык, в строку объект пишем
             * -text */
            Console.ReadKey();
        }
        
    }
}