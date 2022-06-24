using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T, T2>
    {
        T[] keys;
        T2[] values; 
        public MyDictionary()
        {
            keys = new T[0];
            values = new T2[0];
        }
        public void Add(T key, T2 value)
        {
            T[] tempKeys = keys;
            T2[] tempValues = values;

            keys = new T[keys.Length + 1];
            values = new T2[values.Length + 1];
            for (int i = 0; i <tempKeys.Length; i++)
            {
                tempKeys[i] = keys[i];
                tempValues[i] = values[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;    
        }
        public int Count
        {
            get { return keys.Length; }
        }
    }
}
