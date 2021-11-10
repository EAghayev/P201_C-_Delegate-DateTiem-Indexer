using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class MyList<T>: IEnumerable<T>
    {
        public MyList(int size)
        {
            _arr = new T[size];
        }
        private T[] _arr;
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _arr.Length) return _arr[index];
                else throw new IndexOutOfRangeException("Index yoxdur!");
            }
            set
            {
                if (index >= _arr.Length || index < 0) throw new IndexOutOfRangeException("index yanlisdir!");
                else _arr[index] = value;

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
