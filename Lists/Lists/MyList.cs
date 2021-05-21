using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class MyList<T>
    {
        private T[] _items;

        public MyList()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            T[] temp = _items;
            _items = new T[_items.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                _items[i] = temp[i];
            }
        }
    }
}
