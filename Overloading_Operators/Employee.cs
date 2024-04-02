using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operators
{
    // create an employee class
    public class Employee
    {
        // create properties for the employee class
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int ID { get; set; }

        // create an overload for the == operator
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID;
        }

        // create an overload for the != operator
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.ID != employee2.ID;
        }

    }
}
