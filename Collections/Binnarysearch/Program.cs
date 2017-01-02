using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Binnarysearch
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList oArrayList = new ArrayList();
            oArrayList.Add(1);
            oArrayList.Add(3);
            oArrayList.Add(5);
            oArrayList.Add(7);
            int iPos = oArrayList.BinarySearch(3);

            Console.WriteLine(iPos.ToString());
            Console.ReadKey();
        }
    }
}
