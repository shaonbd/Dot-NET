using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserGeneric
{
    class Test<T>
    {
        T _Num;

        public Test(T t)
        {
           
            this._Num = t;
        }

        public void Write()
        {
            Console.WriteLine(this._Num);
        }
    }

    class Program
    {
        static void Main()
        {
           
            Test<int> test1 = new Test<int>(5);
            test1.Write();
            Test<string> test2 = new Test<string>("cat");
            test2.Write();
           Console.ReadKey();
        }
    }

}
