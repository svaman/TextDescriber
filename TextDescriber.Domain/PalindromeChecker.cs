using System;
using TextDescriberDomainInterfaces;

namespace TextDescriberDomain
{
    public class PalindromeChecker : IPalindromeChecker
    {
        public bool IsPalindrome(string inputText)
        {
            var indexFromStart = 0;
            var indexFromEnd = inputText.Length - 1;
            while (indexFromStart < indexFromEnd)
            {
                if (inputText[indexFromStart] != inputText[indexFromEnd])
                {
                    return false;
                }
                indexFromStart++;
                indexFromEnd--;
            }
            return true;
        }
    }
}
