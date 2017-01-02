using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Arraylistcapacity
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("\tCount:    {0}", myAL.Count);
            Console.WriteLine("\tCapacity: {0}", myAL.Capacity);
            Console.Write("\tValues:");
            PrintValues(myAL);
            Console.ReadKey();
        }

        public static void PrintValues(IEnumerable myList)
        {
            IEnumerator myEnumerator = myList.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.Write("\t{0}", myEnumerator.Current);
            Console.WriteLine();
        }


    }
}


