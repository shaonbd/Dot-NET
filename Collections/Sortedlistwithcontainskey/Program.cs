using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sortedlistwithcontainskey
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            //add the elements in sortedlist
            sortedlist.Add(1, "kamal");
            sortedlist.Add(2, "jaleel");
            sortedlist.Add(3, "farook");
            sortedlist.Add(4, "saravanann");
            sortedlist.Add(5, "dinesh");
            sortedlist.Add(6, "shivakumar");
            sortedlist.Add(7, "nirmalkumar");
            //display the elements of the sortedlist
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            //apply contain key method
            Console.WriteLine("The key 1 contain in the SortedList:" + sortedlist.ContainsKey(1));
            Console.WriteLine("The key 5 contain in the SortedList:" + sortedlist.ContainsKey(5));
            Console.WriteLine("The key 10 contain in the SortedList:" + sortedlist.ContainsKey(10));
            Console.WriteLine("The key 50 contain in the SortedList:" + sortedlist.ContainsKey(50));
            Console.ReadKey();
        }
    }
}
