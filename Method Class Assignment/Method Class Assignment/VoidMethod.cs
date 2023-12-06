using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class VoidMethod
    {
        //Void method with two parametars 
        public void assignmentMethod(int number1, int number2)
        {
            int result = number1 % number2;//Do a math operation on first integerr
            Console.WriteLine(number2);//Display the second integer
        }
    }
}
