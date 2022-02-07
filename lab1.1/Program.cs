using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
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
            Console.WriteLine($"Количество элементов в списке:{myList.Length}");

            myList.Add(0);
            myList.Add(45);
            Console.WriteLine($"Количество элементов в списке:{myList.Length}");

            Console.WriteLine($"Элемент под номером 0 в списке:{ myList[0]}") ;
        }
    }
}
