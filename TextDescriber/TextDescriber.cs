using System;
using TextDescriberDomain;

namespace TextDescriber
{
    public class TextDescriber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press quit and press enter to quit");
            var inputText = "";
            while (true)
            {
                inputText = Console.ReadLine();
                if (inputText == "quit")
                {
                    return;
                }
                var outputText = GetOutputValue(inputText);
                Console.WriteLine(outputText);
            }
        }
        
        private static string GetOutputValue(string inputText)
        {
            var palindromeChecker = new PalindromeChecker();

            if (palindromeChecker.IsPalindrome(inputText))
            {
                return "Palindrome";
            }

            var anagramPalindromeChecker = new AnagramPalindromeChecker();

            if (anagramPalindromeChecker.IsAnagramPalindrome(inputText))
            {
                return "Anagram of a palindrome";
            }

            return "Neither";
        }
    }
}
