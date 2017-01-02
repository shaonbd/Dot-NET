using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Arraylistprg
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList pList = new ArrayList();
            pList.Add("kamal");
            pList.Add("Farook");
            pList.Add("Jaleel");  
            Console.WriteLine("=====Original List======");
            for (int i = 0; i < pList.Count; i++)
            {
                string arrayItem = string.Format("Name  is {0}", pList[i]);
                Console.WriteLine(arrayItem);
            }


            Console.WriteLine();
            Console.WriteLine("=====Sort a  List======");
            pList.Sort();
            for (int i = 0; i < pList.Count; i++)
            {
                string arrayItem = string.Format("Name  is {0}", pList[i]);
                Console.WriteLine(arrayItem);
            }
            Console.WriteLine();
            


            //remove first two item from person list using index
            pList.RemoveRange(0,2);  
            Console.WriteLine("=====Modified List======");
            for (int i = 0; i < pList.Count; i++)
            {
                string arrayItem = string.Format("Name  is {0}", pList[i]);
                Console.WriteLine(arrayItem);
            }
            Console.WriteLine();
            pList.Clear();
            int totalItems = pList.Count;
            Console.WriteLine(string.Format("Total Number Of Items in ArrayList :{0}", totalItems));
            Console.WriteLine(pList.Capacity);
            Console.WriteLine();


            



            Console.Read();
        }

        }
    }
