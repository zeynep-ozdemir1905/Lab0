/* Author: Zeynep Ozdemir
 * Lab 0 Basics of C#
 */

//High and Low Integers 

using Lab0;
int low = Utilities.GetPositiveInt("Enter a low number: ");
int high = Utilities.GetIntInRange("Enter a higher number: ", low + 1, int.MaxValue);

// Task 2: Calculate and display the difference
int diff = high - low;
Console.WriteLine($"The difference between {low} and {high} is {diff}");

int[] numbers = new int[diff + 1];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = low + i;
}

// Display numbers from the array using a 'for' loop
Console.WriteLine("Numbers in the array:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Task 4: Write numbers to a file in reverse order
string filePath = "numbers.txt";
Utilities.WriteNumbersToFile(filePath, numbers);

// Task 5: Read numbers back from the file and display using a 'for' loop
int[] numbersFromFile = Utilities.ReadNumbersFromFile(filePath);
Console.WriteLine("Numbers from the file:");
for (int i = 0; i < numbersFromFile.Length; i++)
{
    Console.WriteLine(numbersFromFile[i]);
}
    }
}