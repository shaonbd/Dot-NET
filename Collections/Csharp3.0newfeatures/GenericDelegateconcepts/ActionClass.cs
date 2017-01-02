using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateconcepts
{
    class ActionClass
    {
        static void Main(string[] args)
        {


            Action<string,string> myaction=(x,y)=>Console.WriteLine(x+y);
            myaction("Hello","world");
            Console.ReadLine();
        }
    }
}
