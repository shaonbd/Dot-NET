using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace sortedlistusingdictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList1 = new SortedList();
            sortedList1.Add("one", 1);
            sortedList1.Add("two", 2);
            sortedList1.Add("three", 3);
            sortedList1.Add("four", 4);

            foreach (DictionaryEntry kvp in sortedList1)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            Console.ReadKey();

        }
    }
}
