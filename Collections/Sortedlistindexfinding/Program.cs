using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sortedlistindexfinding
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            //add the elements in sortedlist
            sortedlist.Add(1, "S");
            sortedlist.Add(2, "M");
            sortedlist.Add(3, "T");
            sortedlist.Add(4, "W");
            sortedlist.Add(5, "T");
            sortedlist.Add(6, "F");
            sortedlist.Add(7, "S");
            //IndexOfKey method
            Console.WriteLine("***************INDEXOFKEY***************");
            Console.WriteLine();
            Console.WriteLine("The index value of the key 4 is:" + sortedlist.IndexOfKey(4));
            Console.WriteLine("The index value of the key 1 is:" + sortedlist.IndexOfKey(1));
            Console.WriteLine("The index value of the key 7 is:" + sortedlist.IndexOfKey(7));
            Console.WriteLine("The index value of the key 2 is:" + sortedlist.IndexOfKey(2));
            //IndexofValue method
            Console.WriteLine();
            Console.WriteLine("***************INDEXOFVALUE***************");
            Console.WriteLine();
            Console.WriteLine("The index value of the value Sunday is:" + sortedlist.IndexOfValue("S"));
            Console.WriteLine("The index value of the value Wednesday is:" + sortedlist.IndexOfValue("W"));
            Console.WriteLine("The index value of the value Monday is:" + sortedlist.IndexOfValue("M"));
            Console.WriteLine("The index value of the value Friday is:" + sortedlist.IndexOfValue("F"));
            Console.ReadKey();

        }
    }
}
