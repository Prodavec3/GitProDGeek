using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListMasters;

namespace ConsoleVS
{
    public class Program2
    {
        static public void Main(string[] args)
        {
            ArrayMaster am = new();
            for (int i = 0; i < 20; i++)
            {
                am.Add(new Random().Next(1,20));
            }
            for (int i = 0; i < am.GetCount(); i++)
            {
                Console.WriteLine(am.GetValue(i));
            }
            
        }
    }
}
