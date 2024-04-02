using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_Parameter_Assignment
{
    // creating a generic class called Employee
    public class Employee<T>
    {
        // creating a property list of type T called things
       public List<T> things = new List<T>();
    }
}
