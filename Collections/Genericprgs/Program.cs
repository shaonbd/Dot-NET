using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericprgs
{
    class Person
    {
        int _Age;
 
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        String _Name;
 
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        String _Address;
 
        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        String _Company;
 
        public String Company
        {
            get { return _Company; }
            set { _Company = value; }
        }
 
        public Person() { }
        public Person(string Name)
        {
            this.Name = Name;
            this.Age = 0;
            this.Address = String.Empty;
            this.Company = String.Empty;
        }
        public Person(string Name, int Age, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
        }
       
    class Program
    {
        static void Main(string[] args)
        {
            //Generic List Creation
            //List is a Generic Class provided by .Net Framework 2.0
            //System.Collections.Generics is the Namespace.

            List<Person> myPerson = new List<Person>();
            myPerson.Add(new Person("Saurabh"));
            myPerson.Add(new Person("Manu"));
            myPerson.Add(new Person("SomeOne", 24, "Gurgaon"));
            myPerson.Add(new Person("SomeoneElse", 24, "Gurgaon"));

            //myPerson.Add(new Car());// This is A Compile Time Error

            foreach (Person p in myPerson)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.WriteLine(p.Address);
                Console.WriteLine(p.Company);
            }
            Console.ReadLine();
        }





        }
    }
}
