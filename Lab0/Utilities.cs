using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{

    internal static class Utilities
    {
        // Method to get a positive integer from the user
        public static int GetPositiveInt(string prompt)
        {
            int number = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out number) && number > 0;

                if (!validInput)
                {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }
            return number;
        }

        // Method to get an integer within a specified range
        public static int GetIntInRange(string prompt, int min, int max)
        {
            int number = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out number) && number >= min && number <= max;

                if (!validInput)
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                }
            }
            return number;
        }

        // Method to write numbers to a file in reverse order
        public static void WriteNumbersToFile(string filePath, int[] numbers)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine(numbers[i]);
                }
            }
        }

        // Method to read numbers from a file and return them in an array
        public static int[] ReadNumbersFromFile(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            int[] numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);
            }

            return numbers;
        }
    }
