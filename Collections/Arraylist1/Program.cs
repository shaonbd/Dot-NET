using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.ObjectModel;
using System.Collections;


namespace Arraylist1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Books = new Hashtable();
            Books.Add(1, "asp");
            Books.Add(2, "dotnet");
            Books.Add(3, "java");
            Books.Add(4, "j2ee");
            Books.Add(5, "c#");
            Books.Add(6, "softwareengineering");
            Books.Add(7, "testing");
           



            //Display a single Item 

            
           

            foreach (var item in Books.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach(var item1 in Books.Values)
            {
                Console.WriteLine(item1);
            }

            


            Console.WriteLine(Books["5"]);
            //Search an Item 
            if (Books.ContainsValue("j2ee"))
            {
                Console.WriteLine("Find");
            }
            else
            {
                Console.WriteLine("Not find");
            }
            //remove an Item 
            Books.Remove("3");
            //Display all key value pairs
            foreach (DictionaryEntry day in Books )
            {
               Console.WriteLine(day.Key + "   -   " + day.Value );
            }
            Console.ReadKey();
        }
       
        }
    
    }

