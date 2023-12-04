using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    //Class for three math methods
    class MethodClass
    {
        //Method to divide user's input number by 2
        public static int DivideByTwo(int divide)
        {
            int result = divide / 2;
            return result;
        }

        //Method to multiply user's input by 10
        public static int MultiplyByTen(int multiply)
        {
            int result = multiply * 10;
            return result;
        }

        //Method to raise user's input to the power of two
        public static int PowerOfTwo(int powerOfTwo)
        {
            int result = powerOfTwo * powerOfTwo;
            return result;
        }
    }
}
