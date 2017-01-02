using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateconcepts
{
    class predicateclass
    {
        static void Main(string[] args)
        {

            Predicate<string> chechlength = x => x.Length > 5;
           bool value= chechlength("kamalsingh");
           Console.WriteLine(value);

           List<string> check = new List<string> { "kamal@123", "ravi" };
           string str = check.Find(chechlength);
           Console.WriteLine(str);


            Console.ReadKey();
        }
    }
}
