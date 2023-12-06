using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod object1 = new VoidMethod();//Instance of the VoidMethod class
            object1.assignmentMethod(44, 55);//Call assignmentMethod() with two parametars
            object1.assignmentMethod(number1: 44, number2: 55);//Call assignmentMethod() with two parametars specifying by name

            Console.ReadLine();
        }
    }
}
