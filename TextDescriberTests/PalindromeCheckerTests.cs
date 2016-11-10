using NUnit.Framework;
using TextDescriberDomain;

namespace TextDescriberTests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        [Test]
        public void Describe_WhenPassedValidPalindrome_ReturnsTrue()
        {
            //Arrange
            var textDescriber = new PalindromeChecker();
            var inputString = "anna";
            //Act
            var actualResult = textDescriber.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void Describe_WhenPassedAllSameLetters_ReturnsTrue()
        {
            //Arrange
            var textDescriber = new PalindromeChecker();
            var inputString = "aaaaaaaa";
            //Act
            var actualResult = textDescriber.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void Describe_WhenPassedNonPalindrome_ReturnsFalse()
        {
            //Arrange
            var textDescriber = new PalindromeChecker();
            var inputString = "abca";
            //Act
            var actualResult = textDescriber.IsPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void Describe_WhenPassedPalindromeWithSpaces_ReturnsTrue()
        {
            //Arrange
            var textDescriber = new PalindromeChecker();
            var inputString = "do not bob to nod";
            //Act
            var actualResult = textDescriber.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }
    }
}
