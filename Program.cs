// Create a program that asks the user for a string of input and simply returns it in reverse order. For instance, they enter “Hello” and it returns “olleH”.

// Added Difficulty: Check if the given string is a palindrome.
// (a palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward, such as madam or racecar.)


namespace _02_Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'reverse string'");
            Console.WriteLine();
            Console.WriteLine("Give me a string and I will reverse it.");
            Console.WriteLine("I will also check if the string is a palindrome.");
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("");
                return;
            }
            string reversed = ReverseString(input);
            Console.WriteLine($"Reversed string: {reversed}");
            Console.WriteLine($"Is the string a palindrome? {IsPalindrome(input)}");
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static bool IsPalindrome(string str)
        {
            string reversed = ReverseString(str);
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
