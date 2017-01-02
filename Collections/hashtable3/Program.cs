using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hashtable3
{
    class Program
    {

        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("kamal", 1000);
            hashtable.Add("naser", 55);
            hashtable.Add("kiran", 540);
            return hashtable;
        }

        static void Main(string[] args)
        {
            Hashtable hashtable = GetHashtable();

            // See if the Hashtable contains this key.
            Console.WriteLine(hashtable.ContainsKey("kamal"));

            // Test the Contains method. It works the same way.
            Console.WriteLine(hashtable.Contains("Nambiyar"));

            // Get value of Area with indexer.
            int value = (int)hashtable["naser"];

            // Write the value of Area.
            Console.WriteLine(value);
            Console.ReadKey();

        }
    }
}
