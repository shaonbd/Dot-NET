using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Fixedsizearraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Books = new ArrayList(5);
            Books.Add("Asp");
            Books.Add("Java");
            Books.Add("Ado");
            Books.Add("C#");
            Books.Add("Vb");
            Console.WriteLine(Books.Capacity);
            Console.WriteLine("THE ELEMENTS OF THE ARRAYLIST ARE:");
            Console.WriteLine();
            foreach (string i in Books)
            {
                Console.WriteLine(i);
            }
            // Create a fixed-size wrapper around the ArrayList.
            ArrayList FixedSize = ArrayList.FixedSize(Books);
            Console.WriteLine();
            FixedSize[1] = "php";
            FixedSize.Add("fortran");
            foreach (string i1 in FixedSize)
            {
                Console.WriteLine(i1);
            }

            //Console.WriteLine(FixedSize.Capacity);
            // Display whether the ArrayLists have a fixed size or not.
            Console.WriteLine();
            Console.WriteLine("Books {0}.", Books.IsFixedSize ? "has a fixed size" : "does not have a fixed size");
            Console.WriteLine("FixedSize {0}.", FixedSize.IsFixedSize ? "has a fixed size" : "does not have a fixed size");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
