using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    //Static class cannot be instantiated
    public static class ExampleStaticClass
    {
        //Static method can be called without instance of the class
        public static int divideBy2(int number)
        {
            return number / 2;
        }
    }
}
