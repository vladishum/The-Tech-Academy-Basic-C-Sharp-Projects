using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputInteger object1 = new OutputInteger();
            try
            {
                Console.WriteLine("Enter integer: ");
                int number = Convert.ToInt32(Console.ReadLine());//Get the input as integer
                int result;//Variable for the out variable
                object1.divideBy2(number, out result);//Call the function divideBy2 and pass the out value to result
                Console.WriteLine("Your number divided by 2 is " + result);

                Console.WriteLine("Enter integer: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your number divided by 2 is " + object1.divideBy2(number2));//Call divideBy2 with one parametaar

                Console.WriteLine("Enter integer: ");
                int number3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your number divided by 2 is " + ExampleStaticClass.divideBy2(number3));//Example of static class and function
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
           
        }
    }
}
