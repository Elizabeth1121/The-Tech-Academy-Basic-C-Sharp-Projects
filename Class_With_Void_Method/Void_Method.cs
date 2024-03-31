using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_With_Void_Method
{
    public class Void_Method
    {
        // addition method of type void
        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, result);
        }
    }
}
