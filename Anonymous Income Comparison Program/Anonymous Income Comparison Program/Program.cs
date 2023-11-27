using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display heading for the program
            Console.WriteLine("Anonymous Income Comparison Program\n");

            //Take the corresponding data for the two persons and cast them to decimal
            Console.WriteLine("Person 1\n");
            Console.WriteLine("Hourly rate?");
            decimal person1HR = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Hours worked per week?");
            decimal person1HW = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Person 2\n");
            Console.WriteLine("Hourly rate?");
            decimal person2HR = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Hours worked per week?");
            decimal person2HW = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            //Calculate the annual salary for both persons
            decimal week = 52m;
            decimal person1Salary = person1HR * person1HW * week;
            decimal person2Salary = person2HR * person2HW * week;

            //Display the annual salary for both persons
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(person1Salary.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(person2Salary.ToString());
            Console.WriteLine("\n");

            //Check to see if Person 1 has bigger paycheck than Person 2
            bool checkSalary = person1Salary > person2Salary;
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(checkSalary.ToString());

            Console.ReadLine();
        }
    }
}
