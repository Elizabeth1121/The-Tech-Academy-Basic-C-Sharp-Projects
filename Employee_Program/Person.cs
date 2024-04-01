using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Program
{
    public class Person
    {
        // properties of the Person class
        public string firstName { get; set; }
        public string lastName { get; set; }

        // method of the Person class
        public void sayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }

}
