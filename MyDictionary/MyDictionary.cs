using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T>
    {
        T[] _arrayCount;
        T[] _tempArray;

        public MyDictionary()
        {
            _arrayCount = new T[0];
        }
        public void Add(T item)

        {
            _tempArray = _arrayCount;
            _arrayCount = new T[_arrayCount.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _arrayCount[i] = _tempArray[i];
            }
            _arrayCount[_arrayCount.Length - 1] = item;
        }

        private int myVar;

        public int Count
        {
            get { return _arrayCount.Length; }
        }

    }
}
