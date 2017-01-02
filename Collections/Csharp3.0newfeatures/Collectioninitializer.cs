using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3._0newfeatures
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }





    class Collectioninitializer
    {
        static void Main(string[] args)
        {
            List<Student> sobj = new List<Student>
            {

                new Student{FirstName="kamal",LastName="singh"},
                new Student{FirstName="raja",LastName="singh"}

            };

            foreach (var item in sobj)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.ReadKey();
        }
    }
}
