using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensionclass;

namespace ExtensionMethods
{
   public  static  class Program
    {
       public static void Extrafunction(this Class1 obj)
       {
           Console.WriteLine("Hello I am Extension method");

       }
        
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            obj.Display();
            obj.Print();
            obj.Extrafunction();
            Console.ReadLine();


        }
    }
}
