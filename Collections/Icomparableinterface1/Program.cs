using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Icomparableinterface1
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        #region IComparable<Employee> Members

        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary) return 1;
            else if (this.Salary < other.Salary) return -1;
            else return 0;
            //return Salary.CompareTo(other.Salary);
        }

        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Use Collection Initializers( C# 3.0 ) to initialize the List             
            List<Employee> empList = new List<Employee>() 
	        { 
            new Employee { Name = "a", Salary = 14000 },
            new Employee { Name = "b", Salary = 13000 } 
         };
            empList.Sort();

            foreach (Employee item in empList)
            {
                Console.WriteLine(item.Salary);
            }
            Console.ReadKey();

        }
    }
}
