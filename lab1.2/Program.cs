using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("587", "слово1");
            myDictionary.Add("736", "слово2");
            myDictionary.Add("776", "слово3");
            myDictionary.Add("110", "слово4");
            myDictionary.Add("231", "слово5");
            Console.WriteLine($"Количество элементов в словаре: {myDictionary.Count}");

            Console.WriteLine();

            Console.WriteLine($"Ключ 110, элемент под этим ключем: { myDictionary["110"]}");
            Console.WriteLine($"Ключ 736, элемент под этим ключем: { myDictionary["736"]}");

        }
    }
}
