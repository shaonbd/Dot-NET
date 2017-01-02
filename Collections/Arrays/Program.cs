using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 8, 6, 2 };

            int result1 = Array.IndexOf(array, 6);
            Console.WriteLine(result1);

            int result2 = Array.LastIndexOf(array, 6);
            Console.WriteLine(result2);

            int result3 = Array.LastIndexOf(array, 100);
            Console.WriteLine(result3);

        }
    }
}
