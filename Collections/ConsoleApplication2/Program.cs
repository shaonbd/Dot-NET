using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList obj = new ArrayList();

            obj.Add("kamal");
            obj.Add(1);
            obj.Add('w');


            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
           



          
        }
    }
}
