using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymoustype
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyAnonClass = new
            {
                Name = "kamal",
                Subject = "ASP.Net"
            };
            Console.WriteLine(MyAnonClass.Name);
            Console.Read();
            var SecondAnoynClass = new
            {
                info = MyAnonClass.Name + MyAnonClass.Subject
            };
            Console.WriteLine(SecondAnoynClass.info);
            Console.Read();
        }
    }
}
