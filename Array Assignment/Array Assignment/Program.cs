using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        //Create array of strings and take the users choice for index
        string[] stringArray = { "John", "Jack", "Cat", "Dog", "Fox" };
        Console.WriteLine("Pick a number that is index of the stringArray.");
        int indexStringArray = Convert.ToInt32(Console.ReadLine());
        
        //Check to see if the index exists if it doesn't tell the user if it does exist display the string
        if (indexStringArray > stringArray.Length - 1 || indexStringArray < 0)
            Console.WriteLine("There's no such index in the array!");
        else
            Console.WriteLine("You picked the string " + stringArray[indexStringArray]);

        //Create array of integers and take the users choice for index
        int[] intArray = { 11, 22, 33, 44, 55 };
        Console.WriteLine("Pick a number that is index of the intArray.");
        int indexIntArray = Convert.ToInt32(Console.ReadLine());

        //Check to see if the index exists if it doesn't tell the user if it does exist display the integer
        if (indexIntArray > intArray.Length - 1 || indexIntArray < 0)
            Console.WriteLine("There's no such index in the array!");
        else
            Console.WriteLine("You picked the integer " + intArray[indexIntArray]);

        //Create list of strings and take the users choice for index
        List<string> stringList = new List<string>()
        {
            "Ariel",
            "Buck",
            "Lessy",
            "Kessy",
            "Messy"
        };
        Console.WriteLine("Pick a number that is index of the stringArray.");
        int indexStringList = Convert.ToInt32(Console.ReadLine());

        //Check to see if the index exists if it doesn't tell the user if it does exist display the string
        if (indexStringList > intArray.Length - 1 || indexStringList < 0)
            Console.WriteLine("There's no such index in the array!");
        else
            Console.WriteLine("You picked the string " + stringList[indexStringList]);

        Console.ReadLine();
        }
    }

