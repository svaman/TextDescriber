using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TextDescriberDomain;

namespace TextDescriberTests
{
    [TestFixture]
    public class AnagramPalindromeCheckerTests
    {

        public void IsAnagramPalindrome_AllCharactersSame_ReturnsTrue()
        {
            //Arrange
            var textDescriber = new AnagramPalindromeChecker();
            var inputString = "aaaaaaaa";
            //Act
            var actualResult = textDescriber.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

    }
}
