using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing strings
            string fisrtString = "I am ";
            string secondString = "Bond, ";
            string thirdString = "James Bond";

            Console.WriteLine(fisrtString + secondString + thirdString);//Concatenate strings
            Console.WriteLine(thirdString.ToUpper());//Make the string with all upper letters

            //Creating string with StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a String Builder. ");
            sb.Append("It is used for dynamic creation of strings. ");
            sb.Append("It is good for memory usage. ");
            sb.Append("You should try it.");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
