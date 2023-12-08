using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantied class Employee and add value to the properties and call the SayName method
            Employee Object1 = new Employee() { FirstName = "Sample", LastName = "Student"};
            Object1.SayName();

            Console.ReadLine();
        }
    }
}
