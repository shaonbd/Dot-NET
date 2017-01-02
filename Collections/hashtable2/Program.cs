using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hashtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtableexample = new Hashtable();
            hashtableexample[1] = "One";
            hashtableexample[3] = "Three";
            hashtableexample[29] = "Twenty-Nine";
            foreach (DictionaryEntry entry in hashtableexample)
            {
                Console.WriteLine("{0} : {1}", entry.Key, entry.Value);
            }
            Console.ReadKey();
        }
    }
}
