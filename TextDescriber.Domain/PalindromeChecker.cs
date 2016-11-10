using System;
using TextDescriberDomainInterfaces;

namespace TextDescriberDomain
{
    public class PalindromeChecker : IPalindromeChecker
    {
        public bool IsPalindrome(string inputText)
        {
            var inputTextWithNoSpaces = inputText.Replace(" ", "");
            var indexFromStart = 0;
            var indexFromEnd = inputTextWithNoSpaces.Length - 1;
            while (indexFromStart < indexFromEnd)
            {
                if (inputTextWithNoSpaces[indexFromStart] != inputTextWithNoSpaces[indexFromEnd])
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
