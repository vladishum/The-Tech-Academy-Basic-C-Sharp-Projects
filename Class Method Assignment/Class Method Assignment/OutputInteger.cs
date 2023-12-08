using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class OutputInteger
    {
        //Method with out variable
        public void divideBy2(int number, out int result)
        {
            result = number / 2;
        }

        //Overloading the divideBy2 method
        public int divideBy2(int number)
        {
            return number / 2;
        }
    }
}
