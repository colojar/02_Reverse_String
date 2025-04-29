// Create a program that asks the user for a string of input and simply returns it in reverse order. For instance, they enter “Hello” and it returns “olleH”.

// Added Difficulty: Check if the given string is a palindrome.
// (a palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward, such as madam or racecar.)


namespace _02_Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ReverseStringAndCheckPalindrome();
                string answer;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to enter another string? (yes|y / no|n)");
                    answer = Console.ReadLine().ToLower();

                    if (answer == "no" || answer == "n")
                    {
                        return; // Exit the program
                    }

                    if (answer == "yes" || answer == "y")
                    {
                        Console.Clear();
                        break; // Exit the input validation loop and continue
                    }

                    Console.WriteLine("Invalid input. Please enter 'yes', 'no', 'y', or 'n'.");
                } while (true);
            }
        }

        static void ReverseStringAndCheckPalindrome()
        {
            Console.WriteLine("Welcome to 'reverse string'");
            Console.WriteLine();
            Console.WriteLine("Give me a string and I will reverse it.");
            Console.WriteLine("I will also check if the string is a palindrome.");
            string stringToReverse = string.Empty;
            do
            {
                Console.WriteLine("Please enter a string: ");
                stringToReverse = Console.ReadLine();
            } while (string.IsNullOrEmpty(stringToReverse) || string.IsNullOrWhiteSpace(stringToReverse));
            Console.WriteLine();
            Console.WriteLine($"You entered the string: {stringToReverse}");
            
            // Reverse the string without the Array.Reverse() method
            char[] charArray = stringToReverse.ToCharArray();
            // First index and last index
            int i = 0;
            int j = charArray.Length - 1;
            // Swap first and last index until they meet in the middle
            while (i < j)
            {
                var temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                i++;
                j--;
            }
            // Convert the char array back to a string
            string reversedString = new string(charArray);
            Console.WriteLine($"Reversed string: {reversedString}");

            // Check if the string is a palindrome
            // lowercase the strings
            string lowerCaseString = stringToReverse.ToLower();
            string lowerCaseReversedString = reversedString.ToLower();
            // Compare both strings
            if (lowerCaseString.Equals(lowerCaseReversedString))
            {
                Console.WriteLine($"The string '{stringToReverse}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The string '{stringToReverse}' is not a palindrome.");
            }
        }
    }
}

