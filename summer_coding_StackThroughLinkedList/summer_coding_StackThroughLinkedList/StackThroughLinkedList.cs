using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summer_coding_StackThroughLinkedList
{
    class StackThroughLinkedList <T>
    {
        LinkedList<T> _items = new LinkedList<T>();

        public void Push(T value)
        {
            _items.AddLast(value);
        }

        public T Pop ()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("");
            }
            T resault = _items.Last.Value;
            _items.RemoveLast();
            return resault;
        }

        public T Peek()
        {
            return _items.Last.Value;
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }


    }
}
