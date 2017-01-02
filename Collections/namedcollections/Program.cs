using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace namedcollections
{
    class Program
    {
        public static NameValueCollection GetCollection()
        {
            NameValueCollection collection = new NameValueCollection();
            collection.Add("Kamal", ":INQ");
            collection.Add("Tahmid", "WCF");
            collection.Add("Araf", "Silverlight");
            collection.Add("Farook", "C#");
            collection.Add("Farook", "dot net");
            collection.Add("Jallel", "C#");
            return collection;
        }


        static void Main(string[] args)
        {
                       
                NameValueCollection collection = GetCollection();
                collection.Remove("kamal");
                    // No duplicates returned.
                    foreach (string key in collection.AllKeys)
                    {
                    Console.WriteLine(key + ","+collection[key]);
                    }
                 Console.WriteLine();
                 Console.ReadKey();
        }


             
        }
    }

