using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace sortedlistwithtype
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of sortedlist
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            //add the elements in sortedlist
            sortedlist.Add(5, "Java");
            sortedlist.Add(3, "Asp");
            sortedlist.Add(2, "Vb");
            sortedlist.Add(4, "Php");
            sortedlist.Add(1, "Fortran");
            
            //display the elements of the sortedlist
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
            Console.WriteLine("The capacity is:" + sortedlist.Capacity);
            sortedlist.Add(8, "Oops");
            sortedlist.Add(9, "Testing");
            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            Console.WriteLine("After adding two more element the capacity is:" + sortedlist.Capacity);

            Console.ReadKey();

        }
    }
}
