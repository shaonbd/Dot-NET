using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Isreadonlyprgs
{
    class Program
    {
        static void Main(string[] args)
        {  // Creates a new ArrayList.
            ArrayList days = new ArrayList();
            days.Add("Sunday");
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            // Creates a read-only copy of the ArrayList.
            ArrayList ReadOnly = ArrayList.ReadOnly(days);
            
            // Displays whether the ArrayList is read-only or writable.
            Console.WriteLine("ArrayList days is ReadOnly or not: {0}.", days.IsReadOnly);
            Console.WriteLine("ArrayList ReadOnly is ReadOnly or not: {0}.", ReadOnly.IsReadOnly);
            Console.ReadKey();

        }
    }
}
