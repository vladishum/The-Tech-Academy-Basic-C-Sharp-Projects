using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_of_Learning_Career_College
{   //Simple program for a daily report for students of Academy of Learning Career College.
    class Program
    {
        static void Main(string[] args)
        {
            //Print headings of what the program is for
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            //Get the name of the student
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //Get the course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            //Get the page number like an integer value through casting of string value
            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine());

            //Get the answer like a bool value through casting of string value
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helpbool = bool.Parse(help);

            //Get any positive experience
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();

            //Get feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Get the study hours like integer value through casting string value
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursNum = Convert.ToInt32(hours);

            //Show end message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
