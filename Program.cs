using System;
using System.Collections.Generic;
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

            //***i need to make the 's are cool attach to every string***


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
            List<string> cars = new List<string>();
            cars.Add("Camaro");
            cars.Add("Mustang");
            cars.Add("Challenger");

            //Ask the user to input text to search for in the list.
            Console.WriteLine("To search for an American Muscle car, please enter the model here. The index of the car will be displayed.");
            

            //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            for (int i = 0; i < cars.Count; i++)  //**need help figuring this step out
            {
                // Get element at this index.
                string value = cars[i];
                // Display with string interpolation.
                Console.WriteLine($"Value {i}: {value}");
                Console.ReadLine();

                //Code to check if user input is on the list
                foreach (string car in cars)
                {
                    if (car == "Camaro" || car == "Mustang" || car == "Challenger")
                    {
                        Console.WriteLine("Your have chosen: " + car);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The car you chose is not on the list");
                        break;
                    }
                }

                //PART 5
                //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
                //List<string> subjects = new List<string>() { "English", "Math", "English", "History" };
                //    Console.WriteLine("Select text to search for in the list");



                //    Console.ReadLine();



            }

        }
    }
}
