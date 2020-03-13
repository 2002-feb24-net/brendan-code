using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // behaves like a List<T> but keep itself sorted
    // you declare a class's type parameter with <(name)> right after the class name. 
    class SortedSequence<T>
    {
        List<T> _list = new List<T>();
        {
           Add(new T()):
        }

        public void Add(T item)
        {
            _list.Add(item);
            _list.Sort();
        }
        // implement indexer operator []
        public T this[int i]
        {
            get => _list[i];
            set => _list[i] = value;
        }
    }
}
