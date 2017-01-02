using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3._0newfeatures
{
    class Lambda
    {

        static void Main(string[] args)
        {

            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            // ... Find index of first odd element.
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);
            Console.WriteLine();
            int[] somevalues = { 10, 20, 5, 2, 40, 1 };
            int numberOfExpectedValues = somevalues.Count(x => x > 10);
            Console.WriteLine(numberOfExpectedValues);
            Console.ReadLine();
        }

    }
}
