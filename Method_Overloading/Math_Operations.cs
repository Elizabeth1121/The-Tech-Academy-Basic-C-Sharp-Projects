using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Math_Operations
    {
        // Method to add two integers
        public int Add(int num1)
        {
            return num1 + 5;
        }

        // Method with the sname name but takes in a decimal
        public decimal Add(decimal num1)
        {
            return num1 + 5;
        }

        // Method with the same name but takes in a string
        public string Add(string num1)
        {
            return num1 + "5";
        }
    }
}
