using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Parameters
{
    public class Math_Operations
    {
        // Method to add two numbers, one number is optional
        public int Add(int num1, int num2 = 3)
        {
            return num1 + num2;
        }
    }
}
