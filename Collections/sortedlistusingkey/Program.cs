using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace sortedlistusingkey
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", "Four");
            int i = (int)sortedList["one"];
            int j = (int)sortedList["two"];
            string str = (string)sortedList["four"]; 
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(str);
            Console.WriteLine();

            SortedList sortedList2 = new SortedList();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);

            for (int item = 0; item < sortedList2.Count; item++)
            {
                Console.WriteLine("key: {0}, value: {1}",
                                    sortedList2.GetKey(item), sortedList2.GetByIndex(item));
            }

            Console.ReadKey();
        }
    }
}
