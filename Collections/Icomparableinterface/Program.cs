using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Icomparableinterface
{
    class Employee 
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        
    }
    class Employee_SortBySalaryByAscendingOrder : IComparer<Employee>
    {
        #region IComparer<Employee> Members

        public int Compare(Employee x, Employee y)
        {
            if (x.Salary > y.Salary) return 1;
            else if (x.Salary < y.Salary) return -1;
            else return 0;
        }

        #endregion
    }

    class Employee_SortBySalaryByDescendingOrder : IComparer<Employee>
    {
        #region IComparer<Employee> Members

        public int Compare(Employee x, Employee y)
        {
            if (x.Salary < y.Salary) return 1;
            else if (x.Salary > y.Salary) return -1;
            else return 0;
        }

        #endregion
    }

    class Employee_SortByName : IComparer<Employee>
    {
        #region IComparer<Employee> Member

        public int Compare(Employee x, Employee y)
        {
            return string.Compare(x.Name, y.Name);
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

            Employee_SortBySalaryByAscendingOrder eAsc =
                    new Employee_SortBySalaryByAscendingOrder();
            // Sort Employees by salary by ascending order.   
            empList.Sort(eAsc);
            foreach (Employee   item in empList)
            {
                Console.WriteLine(item.Salary);
            }
            Console.WriteLine();

            Employee_SortBySalaryByDescendingOrder eDsc =
                    new Employee_SortBySalaryByDescendingOrder();
            // Sort Employees by salary by descending order. 
            empList.Sort(eDsc);
            foreach (Employee item1 in empList)
            {
                Console.WriteLine(item1.Salary);
            }
            Console.WriteLine();
            Employee_SortByName eName = new Employee_SortByName();
            // Sort Employees by their names.                                 
            empList.Sort(eName);
            foreach (Employee item2 in empList)
            {
                Console.WriteLine(item2.Name);
            }
            Console.ReadKey();




        }
    }
}
