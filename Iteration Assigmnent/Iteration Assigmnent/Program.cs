using System;
using System.Collections.Generic;

namespace Iteration_Assigmnent
{
    class Program
    {
        static void Main(string[] args)
        {   //Create array of strings and get the text that was written by the user
            string[] stringArray = new string[] { "Messi", "Ronaldo", "Pele", "Maradona", "Eusebio" };
            Console.WriteLine("Please write some text.");
            string text = Console.ReadLine();

            //Append the user's text to the each element of the array
            for(int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += " " + text; 
            }

            //Print every element of the array
            for(int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //Infinite loop
            //for(int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Correction of the infinite loop with changing the stop condition where a clear
            //condition is made
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Comparison that’s used to determine whether to continue iterating the loop is a < operator
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //Comparison that’s used to determine whether to continue iterating the loop is a <= operator
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            List<string> stringList = new List<string>() { "John", "Jack", "Michael", "Toni", "Edward" };
            Console.WriteLine("Please enter a string to search in the list:");
            string search = Console.ReadLine();
            int stringListIndex = 0;
            bool searchMatch = false;

            while (!searchMatch)
            {
                foreach (string item in stringList)
                {
                    if (search == item)
                    {
                        Console.WriteLine("The string matched on index " + stringListIndex);
                        searchMatch = true;
                        break;
                    }
                    else
                    {
                        stringListIndex++;
                        searchMatch = false;
                    }
                    if (stringListIndex == stringList.Count)
                    {
                        stringListIndex = 0;
                        Console.WriteLine("Your string didn't match anything. Enter again: ");
                        search = Console.ReadLine();
                    }
                }
               
            }

            List<string> stringList2 = new List<string>() { "John", "Jack", "John", "Toni", "Jack", "Jack" };
            Console.WriteLine("Please enter a string to search in the list:");
            string search2 = Console.ReadLine();
            int stringListIndex2 = 0;
            bool searchMatch2 = false;

                foreach (string item in stringList2)
                {
                    if (search2 == item)
                    {
                        Console.WriteLine("The string matched on index " + stringListIndex2);
                        searchMatch2 = true;
                    }

                    stringListIndex2++;

                    if (stringListIndex2 == stringList.Count && searchMatch2 == false )
                    {
                        Console.WriteLine("Your string didn't match anything.");
                    }
                }

            List<string> stringList3 = new List<string>() { "Luka", "Lebron", "Luka", "Michael", "Lebron", "Luka" };
            List<string> checkItem = new List<string>();

            foreach(string item in stringList3)
            {
                if (checkItem.Contains(item))
                {
                    Console.WriteLine(item + " This item is a duplicate.");
                }
                else
                {
                    Console.WriteLine(item + " This item is unique.");
                    checkItem.Add(item);
                }

            }

            Console.ReadLine();
        }
    }
}
