using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            myList.Add(83);
            myList.Add(3);
            myList.Add(512);
            myList.Add(6);
            myList.Add(0);
            myList.Add(45);

            Console.Write("Элементы массива: ");
            foreach (var item in ArrayClass<int>.GetArray(myList))
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
