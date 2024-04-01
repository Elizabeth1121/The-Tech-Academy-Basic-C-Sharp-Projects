using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Program
{
    // create a class called Employee that inherits from the Person class
    public class Employee : Person
    {
        // implement the sayName method
        public override void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
