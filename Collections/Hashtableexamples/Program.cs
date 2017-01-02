using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Hashtableexamples
{
    class Program
    {
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Asp", 1000);
            hashtable.Add("Vb", 55);
            hashtable.Add("Java", 540);
            return hashtable;
        }
        public static void Main()
        {
            Hashtable hashtable = GetHashtable();
            // See if the Hashtable contains this key.
            Console.WriteLine(hashtable.ContainsKey("Asp"));
            // Test the Contains method. It works the same way.
            Console.WriteLine(hashtable.Contains("Vb"));
            // Get value of Area with indexer.
            int value = (int)hashtable["Java"];
            // Write the value of Area.
            Console.WriteLine(value);
            Console.ReadKey();
        }

    }
}
