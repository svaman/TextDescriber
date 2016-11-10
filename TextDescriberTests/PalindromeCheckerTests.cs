using NUnit.Framework;
using TextDescriberDomain;

namespace TextDescriberTests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        private PalindromeChecker _palindromeChecker;

        [SetUp]
        public void Setup()
        {
            _palindromeChecker = new PalindromeChecker();
        }

        [Test]
        public void IsPalindrome_WhenPassedValidPalindrome_ReturnsTrue()
        {
            //Arrange
            var inputString = "anna";
            //Act
            var actualResult = _palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedAllSameLetters_ReturnsTrue()
        {
            //Arrange
            var inputString = "aaaaaaaa";
            //Act
            var actualResult = _palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedNonPalindrome_ReturnsFalse()
        {
            //Arrange
            var inputString = "abca";
            //Act
            var actualResult = _palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedPalindromeWithNoSpaces_ReturnsTrue()
        {
            //Arrange
            var inputString = "donotbobtonod";
            //Act
            var actualResult = _palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedPalindromeWithSpaces_ReturnsTrue()
        {
            //Arrange
            var inputString = "do not bob to nod";
            //Act
            var actualResult = _palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsPalindrome_WhenPassedNull_ReturnsFalse()
        {
            //Arrange
            string inputString = null;
            //Act
            var actualResult = _palindromeChecker.IsPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }
    }
}
