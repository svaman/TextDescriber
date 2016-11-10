using NUnit.Framework;
using TextDescriberDomain;

namespace TextDescriberTests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        [Test]
        public void IsPalindrome_WhenPassedValidPalindrome_ReturnsTrue()
        {
            //Arrange
            var palindromeChecker = new PalindromeChecker();
            var inputString = "anna";
            //Act
            var actualResult = palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedAllSameLetters_ReturnsTrue()
        {
            //Arrange
            var palindromeChecker = new PalindromeChecker();
            var inputString = "aaaaaaaa";
            //Act
            var actualResult = palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedNonPalindrome_ReturnsFalse()
        {
            //Arrange
            var palindromeChecker = new PalindromeChecker();
            var inputString = "abca";
            //Act
            var actualResult = palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedPalindromeWithSpaces_ReturnsTrue()
        {
            //Arrange
            var palindromeChecker = new PalindromeChecker();
            var inputString = "do not bob to nod";
            //Act
            var actualResult = palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }
    }
}
