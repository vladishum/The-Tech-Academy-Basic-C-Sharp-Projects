using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class MethodOptional
    {
        public int MethodAssignment(int number1, int number2 = 1)
        {
            int result = number1 * number2;
            return result;
        }
    }
}
