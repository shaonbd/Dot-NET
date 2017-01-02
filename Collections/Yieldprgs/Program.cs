using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yieldprgs
{
    class Program
    {
        static List<int> mylist = new List<int>();
        static void Fillvalues()
        {
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);
        }

        static void Main(string[] args)
        {
            Fillvalues();

            foreach (int item in Filter())
            {
                Console.WriteLine(item); 
            }

            Console.ReadKey();
        }


        static IEnumerable<int> Filter()
        {
           // List<int> temp = new List<int>();
            foreach (int i  in mylist)
            {
                if (i > 3)
                {
                   // temp.Add(i);
                    yield return i;
                }
           
            }
           // return temp;


        }

    }
}
