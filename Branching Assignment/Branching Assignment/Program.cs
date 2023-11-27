using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dispaly heading for the program and get the package weight from the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            //If the package weight is more than 50 stop the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            //If the package weight is less then 50 do this block
            else
            {
                //Get the dimensions for the package from the user
                Console.WriteLine("Please enter the package width:");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                decimal height = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                //If the package is too big stop the program
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }

                //If package dimensions are OK do this block
                else
                {
                    //Calculate the amount needed for the package and display it 
                    decimal quote = width * height * length * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }

        }
    }
}
