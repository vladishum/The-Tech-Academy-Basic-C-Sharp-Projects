using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Employee1 = new Employee<string>(); //Object with string type as generic parameter
            Employee1.Things = new List<string>() { "Gloves", "Shoes", "Hat", "Hammer", "Screwdriver" }; //Make the Things property list of strings

            Employee<int> Employee2 = new Employee<int>(); //Object with int type as generic parameter
            Employee2.Things = new List<int>() { 10, 20, 30, 40, 50 }; //Make the Things property list of integers

            foreach (string thing in Employee1.Things)
            {
                Console.WriteLine(thing); //Display the property Things of the Employee1 object
            }

            foreach (int thing in Employee2.Things)
            {
                Console.WriteLine(thing); //Display the property Things of the Employee2 object
            }

            Console.ReadLine();

        }
    }
}
