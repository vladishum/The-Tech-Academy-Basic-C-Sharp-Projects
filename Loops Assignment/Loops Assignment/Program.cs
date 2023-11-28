using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop to get number smaller than 10
            int number = Convert.ToInt32(Console.ReadLine());
            bool rightNumber = number >= 10;//Boolean logic to get number smaller than 10
            while(rightNumber)//While loop
            {
                Console.WriteLine("Not the number you need. Try again.");
                number = Convert.ToInt32(Console.ReadLine());
                rightNumber = number >= 10;
            }
            Console.WriteLine("Good for you. That's the number you want.");

            //Do while loop to get the animal wolf
            Console.WriteLine("What's your favorite anumal?");
            string animal = Console.ReadLine();
            bool rightAnimal = animal == "wolf";//Boolean logic
            do//Do while loop
            {
                if (animal == "wolf")
                {
                    Console.WriteLine("That's the animal. Great job!");
                    break;
                }
                Console.WriteLine("Try again.");
                animal = Console.ReadLine();
            }
            while (!rightAnimal);

            Console.ReadLine();
        }
    }
}
