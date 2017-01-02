using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> countries = new HashSet<string> { "JAPAN", "USA", "AUSTRALIA", "CANADA", "CHINA", "RUSSIA", "FRANCE" };

            Console.WriteLine(countries.Contains("AUSTRALIA"));

            Console.WriteLine(countries.Contains("ENGLAND"));

            Console.ReadLine();

        }
    }
}
