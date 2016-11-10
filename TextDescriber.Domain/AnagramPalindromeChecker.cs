using System.Collections.Generic;
using System.Linq;

namespace TextDescriberDomain
{
    public class AnagramPalindromeChecker
    {
        public bool IsAnagramPalindrome(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return false;
            }
            var inputTextWithNoSpaces = inputText.Replace(" ", "");
            var chars = inputTextWithNoSpaces.ToCharArray().ToList();

            var charWithoutPairAlreadyExists = false;

            var charDictionary = new List<char>();
            foreach (var character in inputTextWithNoSpaces)
            {
                if (!charDictionary.Contains(character))
                {
                    var characterFrequency = chars.FindAll(x => x == character).Count;
                    charDictionary.Add(character);
                    if (characterFrequency%2 != 0)
                    {
                        if (charWithoutPairAlreadyExists)
                        {
                            return false;
                        }
                        charWithoutPairAlreadyExists = true;
                    }
                }
            }

            return true;
        }
    }
}
