using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user which number they want and get that number
            Console.WriteLine("What number do you want the operations on?");
            int number = Convert.ToInt32(Console.ReadLine());

            //Call the methods from the MethodClass and display the result
            Console.WriteLine(number + " divided by 2 is " +MethodClass.DivideByTwo(number));
            Console.WriteLine(number + " multiplyed by 10 is " + MethodClass.MultiplyByTen(number));
            Console.WriteLine(number + " to the power of two is " + MethodClass.PowerOfTwo(number));

            Console.ReadLine();
        }
    }
}
