using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace practicalprgs
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            Console.WriteLine(obj.Capacity);
           
            obj.Add(1);
            Console.WriteLine(obj.Capacity);
            obj.Add(2);
            obj.Add(3);
            obj.Add(3);
            obj.Add(3);
            obj.Add(3);
            obj.Add("kamal");
            obj.Add("kamal");
            obj.Add("kamal");
           // Console.WriteLine(obj.Capacity);
           // obj.RemoveRange(0, 4);
           //obj.TrimToSize();
            
            Console.WriteLine(obj.Capacity);
           Console.WriteLine(obj.Count);
           Console.WriteLine();
           obj.TrimToSize();
           Console.WriteLine(obj.Capacity);
            //for (int i = 0; i < obj.Count; i++)
            //{
            //    Console.WriteLine(obj[i]);
            //}

            //Console.WriteLine();

            //foreach (var item in obj)
            //{
            //    Console.WriteLine(item);
            //}





            //int val = (int)obj[2];
            //Console.WriteLine(val);
            
            Console.ReadKey();


        }
    }
}
