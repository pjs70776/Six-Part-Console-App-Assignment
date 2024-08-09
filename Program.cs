using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Six Part Console App");
            Console.ReadLine();

            ////PART 1
            ////array of strings and user input
            //    string[] MyCar = { "Tesla", "Rivian", "Lucid", "Dodge" };

            //    // Ask the user to input some text.
            //    Console.WriteLine("Please enter the following: 's are cool.");
            //    string userInput = Console.ReadLine();

            //    // A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            //    for (int i = 0; i < MyCar.Length; i++)
            //    {
            //        MyCar[i] = MyCar[i] + userInput;
            //    }
            //    // Then create a second loop that prints off each string in the array one at a time.
            //    foreach (string car in MyCar)
            //    {
            //        Console.WriteLine(car);
            //    }
            //}

            //    Console.ReadLine();

            


            ////PART 2
            ////Infinite loop
            //while (true)
            //{
            //    Console.WriteLine("Oh hi, Mark");
            //    //I inserted Console.Readline(); to fix the infinite loop
            //    Console.ReadLine();
            //}

            //PART 3
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            //int[] speed = { 35, 45, 55, 65, 75 };

            //for (int i = 0; i < speed.Length; i++)
            //{
            //    if (speed[i] > 55)
            //    {
            //        Console.WriteLine(speed[i] + " is too fast for this road, slow down.");
            //    }
            //}
            //Console.ReadLine();

            ////Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            //int[] speed2 = { 35, 45, 55, 65, 75 };

            //for (int i = 0; i < speed2.Length; i++)
            //{
            //    if (speed[i] <= 45)
            //    {
            //        Console.WriteLine(speed2[i] + " is too slow for the freeway.");
            //    }
            //}
            //Console.ReadLine();

            //PART 4
            //A list of strings where each item in the list is unique.
            //List<string> cars = new List<string>() { "Camaro", "Mustang", "Challenger" };

            ////Ask the user to input text to search for in the list.
            //Console.WriteLine("Please choose and type one of the following: Camaro, Mustang, Challenger");
            //string car = Console.ReadLine();

            //bool carFound = false;
            ////A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            //for (int i = 0; i < cars.Count; i++) 
            //{
            //    if (cars[i].Equals(car, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"You have chosen: '{cars[i]}' in index {i}.");
            //        carFound = true;
            //        break;
            //    }
            //}
            //if (!carFound)
            //{
            //    Console.WriteLine("Car is not on the list.");
            //}
            //Console.ReadLine();


            //PART 5
            //A list of strings that has at least two identical strings in the list
            //List<string> subjects = new List<string>() { "Math", "Math", "History", "Science" };

            ////Ask the user to input text to search for in the list.
            //Console.WriteLine("Please choose and type one of the following: Math, History, Science.");
            //string selectedSubject = Console.ReadLine();

            //bool subjectFound = false;
            ////A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            //for (int i = 0; i < subjects.Count; i++)
            //{
            //    if (subjects[i].Equals(selectedSubject, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"You have chosen: '{selectedSubject[i]}' in index {i}.");
            //        subjectFound = true;
            //        break;
            //    }
            //}
            //if (!subjectFound)
            //{
            //    Console.WriteLine("Subject is not on the list.");
            //}
            //Console.ReadLine();

            //PART 6
            //A list of strings that has at least two identical strings in the list
            //List<string> letters = new List<string>() { "A", "B", "B", "C" };
            //List<string> duplicateLetters = new List<string>();

            ////foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            //foreach (string letter in letters)
            //{
            //    if (duplicateLetters.Contains(letter))
            //        {
            //        Console.WriteLine(letter + " - this item is a duplicate");
            //    }
            //    else 
            //        {
            //        Console.WriteLine(letter + " - this item is unique");
            //        duplicateLetters.Add(letter);
            //    }
            //    //Console.WriteLine(i);
            //}
            //Console.ReadLine();
        }

    }
    }



