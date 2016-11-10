using NUnit.Framework;
using TextDescriberDomain;

namespace TextDescriberTests
{
    [TestFixture]
    public class AnagramPalindromeCheckerTests
    {
        private AnagramPalindromeChecker _anagramPalindromeChecker;
        [SetUp]
        public void Setup()
        {
            _anagramPalindromeChecker = new AnagramPalindromeChecker();
        }

        [Test]
        public void IsAnagramPalindrome_WhenPassedAllCharactersSame_ReturnsTrue()
        {
            //Arrange
            var inputString = "aaaaaaaa";
            //Act
            var actualResult = _anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_WhenPassedSameCharacterEvenTimesAndOneDifferentCharacter_ReturnsTrue()
        {
            //Arrange
            var inputString = "aaaaaaaab";
            //Act
            var actualResult = _anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_WhenPassedMoreThanOneDifferentLetter_ReturnsFalse()
        {
            //Arrange
            var inputString = "caaaaaaaab";
            //Act
            var actualResult = _anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_WhenPassedManyDifferentLetters_ReturnsFalse()
        {
            //Arrange
            var inputString = "owefhijpfwai";
            //Act
            var actualResult = _anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_DifferentLettersButOneWithNoMatch_ReturnsTrue()
        {
            //Arrange
            var inputString = "igdedgide";
            //Act
            var actualResult = _anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_PassedNull_ReturnsFalse()
        {
            //Arrange
            string inputString = null;
            //Act
            var actualResult = _anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_DifferentLettersButOneWithNoMatchAndASpace_ReturnsTrue()
        {
            //Arrange
            var inputString = "igded gide";
            //Act
            var actualResult = _anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }
    }
}
