using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keyArray = null;
        private TValue[] valueArray = null;
        private int count = 0;


        public int Count
        {
            get { return count; }
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (key.Equals(keyArray[i]))
                        index = i;
                }
                return valueArray[index];
            }
        }
        public void Add(TKey key, TValue val)
        {
            count++;

            Array.Resize(ref keyArray, count);
            keyArray[count - 1] = key;

            Array.Resize(ref valueArray, count);
            valueArray[count - 1] = val;
        }

        
    }
}
