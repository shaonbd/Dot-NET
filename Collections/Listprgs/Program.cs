using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listprgs
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> years = new List<int>();
            years.Add(1991);
            years.Add(1992);
            years.Add(1993);
            years.Add(1994);
            years.Add(2001);
            years.Add(2002);
            years.Add(2003);
            years.Add(2004);



            //IEnumerable<int> ienum = (IEnumerable<int>)years;

            // iterate19to2001(ienum);
            //foreach (var item in ienum)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();

            IEnumerator<int> ienumer = years.GetEnumerator();
            iterate19to2001(ienumer);

            //while (ienumer.MoveNext())
            //{
            //    Console.WriteLine(ienumer.Current.ToString());
            //}
            Console.ReadKey();
        }

        static void iterate19to2001(IEnumerator<int> o)
        {

            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
                if (Convert.ToInt16(o.Current) > 2000)
                {

                    iterate2001andabove(o);

                }
            }


        }

        //static void iterate19to2001(IEnumerable<int> o)
        //{
        //    foreach (int  item in o)
        //        {
        //        if (item > 2000)
        //        {

        //            iterate2001andabove(o);

        //        }

        //        }


        //    }
        //static void iterate2001andabove(IEnumerable<int> o)
        //  {
        //         foreach (int  item in o)
        //             {
        //             Console.WriteLine(item);



        //             }
        //  }





        static void iterate2001andabove(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {

                Console.WriteLine(o.Current.ToString());
            }
        }
    }
}
