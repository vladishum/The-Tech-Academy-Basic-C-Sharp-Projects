using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\vladi\source\repos\Logs\IOAssignment.txt", number.ToString());//Writing to a File
            string text = File.ReadAllText(@"C:\Users\vladi\source\repos\Logs\IOAssignment.txt");//Reading from a File
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
