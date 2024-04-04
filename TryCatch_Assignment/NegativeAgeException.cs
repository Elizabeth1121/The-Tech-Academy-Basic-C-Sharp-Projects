using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    // NegativeAgeException class
    public class NegativeAgeException : Exception
    {
        // NegativeAgeException constructor
        public NegativeAgeException() : base() { }

        // NegativeAgeException constructor with message
        public NegativeAgeException(string message) : base(message) { }
    }
}
