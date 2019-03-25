using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.CustExpections
{
    class LengthException : Exception
    {
        public LengthException() { }

        public LengthException(string message) : base(message) { } 
    }
}
