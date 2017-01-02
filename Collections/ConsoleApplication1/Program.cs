using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add("kamal");
            al.Add("Tahmid");
            al.Add("kamal");
            al.Add("Tahmid");
            al.Add("kamal");
            al.Add("Tahmid");
            Console.WriteLine(al.Capacity);
            Console.WriteLine(al.Count);
            Console.ReadKey();

           

        }
    }
}
