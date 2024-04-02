using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Program
{
    // Employee class inherits from Person class and implements IQuittable interface
    public class Employee : Person, IQuittable
    {
        // Id property
        public int Id { get; set; }

        // SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Quit method
        public void Quit()
        {
            Console.WriteLine("Employee has quit.");
        }
    }
    
}
