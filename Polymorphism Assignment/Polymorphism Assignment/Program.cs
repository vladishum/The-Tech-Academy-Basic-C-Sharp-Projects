using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable Object1 = new Employee() { FirstName = "John", LasName = "Doe" }; //Using polymorphism to create object
            Object1.Quit(); //Call the function Quit
        }
    }
}
