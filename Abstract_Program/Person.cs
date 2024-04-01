using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Program
{
    // create an abstract class called Person
    public abstract class Person
    {
        // create two string properties called firstName and lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        // create an abstract method called sayName
        public abstract void sayName();
    }
}
