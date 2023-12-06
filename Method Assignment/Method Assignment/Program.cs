using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOptional object1 = new MethodOptional();//Instantiation of class MethodOptional
            Console.WriteLine("Enter two numbers. Second one is optional");
            int number1 = Convert.ToInt32(Console.ReadLine());//Get the first number

            //Check if a second number is entered
            try
            {
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The result of multiplying your numbers is " + object1.MethodAssignment(number1, number2));
            }

            //If a second number is not entered do this
            catch
            {
                Console.WriteLine("You entered just one number. Number " + object1.MethodAssignment(number1));
            }

            Console.ReadLine();
        }
    }
}
