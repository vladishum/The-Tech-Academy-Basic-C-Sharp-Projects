using System;
using System.Collections.Generic;

namespace Try_Catch_Finally_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {   //Create List of integers and ask for a number to divide by
            List<int> integerList = new List<int>() { 1, 5, 77 , 33, 432, 111 };
            Console.WriteLine("Enter number which you want to divide by: ");
            
            //Try block to check for right number format
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                foreach (int item in integerList)
                {
                    Console.WriteLine(item + " divided by " + number + " is " + item / number);
                }
            }

            //Catch block for Format exception that displays to the user what is the error
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Catch block for Divide By Zero exception that displays to the user what is the error
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Show message that program has exited the try/catch block
            Console.WriteLine("Program has exited try catch/block.");
            Console.ReadLine();
        }
    }
}
