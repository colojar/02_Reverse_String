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
                stringToReverse = InputString();
            } while (string.IsNullOrEmpty(stringToReverse) || string.IsNullOrWhiteSpace(stringToReverse));
            Console.WriteLine();
            Console.WriteLine($"You entered the string: {stringToReverse}");
            string reversedString = ReverseString(stringToReverse);
            Console.WriteLine($"Reversed string: {reversedString}");
            Console.WriteLine($"Is the string a palindrome? {IsPalindrome(stringToReverse)}");
        }
        static string InputString()
        {
            Console.Clear();
            Console.WriteLine("Please enter a string: ");
            string input = Console.ReadLine();
            return input;
        }
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static string IsPalindrome(string str)
        {
            string reversed = ReverseString(str);
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";

        }
    }
}

