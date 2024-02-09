using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());//Prints current datetime
            Console.WriteLine("Enter number:");//Asks user to enter number
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After {0} hours datetime will be " + DateTime.Now.AddHours(number), number);//Using AddHours to print the datetime after the number entered by the user
            Console.ReadLine();
        }
    }
}
