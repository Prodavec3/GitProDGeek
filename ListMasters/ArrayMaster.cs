using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMasters
{
    public class ArrayMaster // массив хранящий данные, и метод, который меняет размер массива на +1 от того что есть и
                             // заполняет последний элемент
    {
        int[] storage = new int[0];
        int count = 0;

        public void Add(int item)
        {
            Array.Resize(ref storage, count + 1);
            storage[count++] = item; // сначала присваиваем, потом увеличиваем
        }

        public int GetValue(int index)
        {
            return storage[index];
        }

        public int GetCount()
        {
            return count;
        }
    }
}
