using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Addrangeprgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack oStack = new Stack();
            oStack.Push(1);
            oStack.Push(2);
            oStack.Push(3);
            oStack.Push(4);

            ArrayList oArrayList = new ArrayList();
            oArrayList.Add("Senthil");
            oArrayList.Add("Kumar");
            oArrayList.AddRange(oStack);
            //oArrayList.Sort();

            foreach (var item in oArrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
