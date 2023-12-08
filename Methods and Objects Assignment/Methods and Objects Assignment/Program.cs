using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object of type Employee and initialize the properties FirstName and LastName
            Employee Object1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the method SayName on the new object
            Object1.SayName();

            Console.ReadLine();
        }
    }
}
