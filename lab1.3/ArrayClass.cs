using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._3
{
    static class ArrayClass<T>
    {
       public static T[] GetArray(MyList<T> list)
       {
            T[] myArray = new T[list.myList.Count()];
            for (int i = 0; i < list.myList.Count(); i++)
            {
                myArray[i] = list.myList[i];
            }
            return myArray;
       }
    }
}
