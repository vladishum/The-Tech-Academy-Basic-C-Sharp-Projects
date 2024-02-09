using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int answer;
            bool valid = false;
            while (!valid)//Do the loop until you get the proper input
            {
                try//try block to check that the unput is a number and greter than zero and not negative
                {
                    Console.WriteLine("What's your age?");
                    answer = Convert.ToInt32(Console.ReadLine());//Get the input
                    if (answer > 0)//If it is greater than zero OK
                    {
                        Console.WriteLine("You were born " + (Convert.ToInt32(DateTime.Now.Year.ToString()) - answer));
                        valid = true;
                        Console.ReadLine();
                    }
                    else throw new LessOrZero();//Else throw exception
                }
                catch (LessOrZero)//Catch if number is less or zero
                {
                    Console.WriteLine("No negative numbers or zero! ");
                }
                catch (Exception)//Catch for any other exception
                {
                    Console.WriteLine("Enter number, no decimals please!");
                    valid = false;
                }
            }
           
        }
    }
}
