using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_And_Comparison_Operations_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input number casts it to integer and displays the number multiplied by 50
            Console.WriteLine("Enter number");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number multiplied by 50 is " + (multiplier * 50).ToString());

            //Takes a number casts it to integer and displays the number added by 25
            Console.WriteLine("Enter number");
            int adder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number added by 25 is " + (adder + 25).ToString());

            //Takes a number casts it to double and displays the number divided by 12.5
            Console.WriteLine("Enter number");
            double divider = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number divided by 12.5 is " + (divider / 12.5).ToString());

            //Takes a number casts it to double then initializes checkFifty to True or False and displays checkFifty's value
            Console.WriteLine("Enter number");
            double greaterThanFifty = Convert.ToDouble(Console.ReadLine());
            bool checkFifty = greaterThanFifty > 50.0;
            Console.WriteLine("Is your number is greater than fifty? - " + checkFifty.ToString());

            //Takes a number casts it to double and displays the remainder of the number divided by 7
            Console.WriteLine("Enter number");
            double divideSeven = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The remainder of your number divided by 7 is " + (divideSeven % 7).ToString());

            Console.ReadLine();
        }
    }
}
