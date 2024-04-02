using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Program
{
    // Person abstract class
    public abstract class Person
    {
        // FirstName property
        public string FirstName { get; set; }
        // LastName property
        public string LastName { get; set; }
        // SayName method
        public abstract void SayName(); 
    }
}
