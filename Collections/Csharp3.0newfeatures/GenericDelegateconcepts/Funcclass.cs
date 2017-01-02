using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateconcepts
{
    class Funcclass
    {
        
        static void Main(string[] args)
        {
            Func<double,double> Values=r=>3.12*r*r;
            double area=  Values(2);
            Console.WriteLine(area);
            Console.ReadKey();
               
            }
        }
    }

