using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTickets = Convert.ToInt32(Console.ReadLine());
            bool qualified = (age > 15) && !dui && (speedTickets <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified.ToString());
            Console.ReadLine();
        }
    }
}
