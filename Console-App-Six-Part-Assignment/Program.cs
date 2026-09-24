using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console_App_Six_Part_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // A one-dimensional array of strings
            string[] stringArray = { "Hello", "World", "C#", "Programming" };

            // Collect user input
            Console.WriteLine("Please enter some text to be appended to each item in the array:");
            string userInput = Console.ReadLine();

            // Append the user input to each item in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            // Display the modified array
            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }

            // Assignment Part 2
            // This infinite loop was fixed with a break condition and a counter
            int counter = 0;
            Console.WriteLine("\nStarting infinite loop. It will break after 10 iterations.");
            while (true)
            {
                // Display the current counter value
                Console.WriteLine(counter);
                if (counter >= 10)
                {
                    Console.WriteLine("Counter has reached 10. Breaking the loop.");
                    break; // Break the loop after 10 iterations
                }
                // Increment the counter
                counter++;

            }

            // Assignment Part 3
            // Loop where the comparison used is "<"
            string[] fruits = { "Banana", "Apple", "Orange", "Grapes" };

            for (int j = 0; j < fruits.Length; j++)
            {
                Console.WriteLine(fruits[j]);
            }

            // Loop where the comparison used is "<="
            for (int k = 0; k <= 10; k++)
            {
                Console.WriteLine($"Current value of k: {k}");
            }

            // Assignment Part 4
            // A list of strings that the user can search for a string in the list and once a match if found exits the loop
            List<string> colors = new List<string> { "red", "green", "blue", "yellow", "orange", "purple" };

            // Prompt the user to enter a color to search for
            Console.WriteLine("\nPlease enter a color to search for in the list:");
            string colorInput = Console.ReadLine().ToLower();

            // Flag to indicate if the color was found
            bool colorFound = false;
            // Loop through the list of colors and check for a match
            for (int l = 0; l < colors.Count; l++)
            {
                Console.WriteLine($"Checking color: {colors[l]}");
                // If a match is found, set the flag to true and break the loop
                if (colors[l] == colorInput)
                {
                    Console.WriteLine($"Color '{colorInput}' found in the list at index {l}.");
                    colorFound = true;
                    break;
                }
            }

            // If no match was found, inform the user
            if (!colorFound)
            {
                Console.WriteLine($"Color '{colorInput}' not found in the list.");
            }

            // Assignment Part 5
            // A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> animals = new List<string> { "cat", "dog", "bird", "cat", "fish", "dog" };

            Console.WriteLine("\nPlease enter an animal to search for in the list:");
            string animalsInput = Console.ReadLine().ToLower();

            //Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.Ensure to remove any break statements that may prevent your code from returning multiple matches.
            bool animalFound = false;
            int timesFound = 0;
            for (int m = 0; m < animals.Count; m++)
            {
                if (animals[m] == animalsInput)
                {
                    Console.WriteLine($"Animal '{animalsInput}' found at index {m}.");
                    timesFound++;
                    animalFound = true;
                }
            }

            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. (You do not need to provide any additional chances for the user to enter text.)
            // If the animal was not found, inform the user
            if (!animalFound)
            {
                Console.WriteLine($"Animal '{animalsInput}' not found in the list.");
            } 
            else
            {
                // If the animal was found, inform the user how many times it was found
                Console.WriteLine($"Animal '{animalsInput}' was found {timesFound} time(s) in the list.");
            }

            // Assignment Part 6
            // A list of strings that has at least two identical strings in the list.
            List<string> cities = new List<string> { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Chicago", "Toronto", "Toronto" };
            // Create an array to store duplicate cities
            string[] duplicateCities = new string[cities.Count];

            // Create a loop that iterates through the list and then displays a message showing each city in the list and whether or not it has already appeared in the list.
            for (int n = 0; n < cities.Count; n++)
            {
                // Store the current city in a variable
                string currentCity = cities[n];
                // Check if the current city has already appeared in the list
                for (int o = n + 1; o < cities.Count; o++)
                {
                    // If the current city is found again in the list, store it in the duplicateCities array
                    if (cities[o] == currentCity)
                    {
                        //Console.WriteLine($"Duplicate city '{currentCity}' found at index {o} (first occurrence at index {position}).");
                        duplicateCities[o] = cities[o];
                    }
                }
                // Display whether the current city is a duplicate or unique
                Console.WriteLine($"City '{currentCity}' is {(duplicateCities[n] != null ? "a duplicate" : "unique")}.");
            }

            //So program pauses so user can see the output before closing
            Console.ReadLine();
        }
    }
}
