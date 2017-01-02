using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashsetprgs
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> nameHashSet =
                   new HashSet<string>
                {
                    "Jalpesh", "Vishal", "Tushar", "Jalpesh"
                };
            foreach (var item in nameHashSet)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
