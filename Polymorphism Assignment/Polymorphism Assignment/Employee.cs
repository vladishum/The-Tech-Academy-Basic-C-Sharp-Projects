using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    public class Employee : Person, IQuittable //Inherits from class Person and interface IQuittable 
    {
        public override void SayName() //Method which dispalys the full name of employee
        {
            Console.WriteLine("Name: " + FirstName + " " + LasName);
        }

        public void Quit() //Method to check if you want to quit
        {
            bool quit = false;
            Console.WriteLine("Do you really want to quit? Y or N");
            string answer = Console.ReadLine().ToString();
            while (!quit) //Until the user enters Y or N continue with the loop
            {
                if (answer == "Y") //If entered Y dispaly message You quit!
                {
                    quit = true;
                    Console.WriteLine("You quit!");
                    Console.ReadLine();
                }

                else if (answer == "N") //If entered N dispaly message You don't quit!
                {
                    quit = true;
                    Console.WriteLine("You don't quit!");
                    Console.ReadLine();
                }
                else //Else display that you have to enter Y or N
                {
                    Console.WriteLine("Enter Y or N");
                    answer = Console.ReadLine().ToString();
                }
            }

        }
    }
}
