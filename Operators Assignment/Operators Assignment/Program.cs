using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate objects Employee with same Id
            Employee employee1 = new Employee() { Id = 5, FirstName = "John", LastName = "Smith"};
            Employee employee2 = new Employee() { Id = 5, FirstName = "Steve", LastName = "Gold"};

            //Check if the objects are equal based on Id
            if(employee1 == employee2)
            {
                Console.WriteLine("Employee with same Id");
            }
            else
            {
                Console.WriteLine("Employee with different Id");
            }

            Console.ReadLine();
        }
    }
}
