using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDescriberDomain
{
    public class AnagramPalindromeChecker
    {
        public bool IsAnagramPalindrome(string inputText)
        {
            var chars = inputText.ToCharArray().ToList();

            var charWithoutPairExists = false;

            var charDictionary = new Dictionary<char, int>();
            foreach (var character in inputText)
            {
                if (!charDictionary.ContainsKey(character))
                {
                    var characterFrequency = chars.FindAll(x => x == character).Count;
                    charDictionary.Add(character, characterFrequency);
                    if (characterFrequency%2 != 0)
                    {
                        if (charWithoutPairExists == false)
                        {
                            charWithoutPairExists = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
