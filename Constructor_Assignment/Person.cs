using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Person
    {
        // declaring the fields of the Person class
        public string fName;
        public string lName;

        // creating a default constructor
        public Person() : this("John", "Doe")
        {
        }

        // creating a constructor with parameters
        public Person(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }
    }
}
