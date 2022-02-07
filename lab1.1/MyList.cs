using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
{
    class MyList<T>
    {
        private List<T> myList = new List<T>();
        
        public T this[int index]
        {
            get
            {
                return myList[index];
            }
            set
            {
                myList[index] = value;
            }
        }
        public int Length { get { return myList.Count; } }

        public void Add(T element)
        {
            myList.Add(element);
        }
    }
}
