using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3._0newfeatures
{
    class Lambdawithdelegate
    {
        //delegate for representing anonymous method
        delegate int del(int x, int y);

        static void Main(string[] args)
        {
            //anonymous method using expression lamda
            del d1 = (x, y) => x * y;
            // or (int x, int y) => x * y;

            //anonymous method using statement lamda
            del d2 = ( x, y) => { return x * y; };
            // or (int x, int y) => { return x * y; };

            //anonymous method using delegate keyword
            del d3 = delegate(int  x, int y) { return x * y; };

            int z1 = d1(2, 3);
            int z2 = d2(3, 3);
            int z3 = d3(4, 3);

            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine(z3);
            Console.ReadLine();
        }
    }
}
