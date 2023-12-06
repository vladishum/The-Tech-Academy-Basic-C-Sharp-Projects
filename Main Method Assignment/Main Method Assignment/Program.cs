using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the IntegerOperations class
            IntegerOperations object1 = new IntegerOperations();

            //Call the overloaded FunctionInteger with 3 different parametars
            Console.WriteLine(object1.FunctionInteger(10));
            Console.WriteLine(object1.FunctionInteger(10.35m));
            Console.WriteLine(object1.FunctionInteger("rfre"));

            Console.ReadLine();
        }
    }
}
