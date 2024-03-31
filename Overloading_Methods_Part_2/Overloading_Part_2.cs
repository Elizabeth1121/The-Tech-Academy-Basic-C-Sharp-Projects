using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Methods_Part_2
{
    public static class Overloading_Part_2
    {
        // creating a void method that outputs an int
        public static void MyMethod(int x)
        {
            Console.WriteLine(x / 2);
        }

        // method with output parameters
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        // overloaded method with output parameters
        public static int Multiply(int x, int y, int z)
        {
            return x * y * z;
        }
    }
}
