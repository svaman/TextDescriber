using NUnit.Framework;
using TextDescriberDomain;

namespace TextDescriberTests
{
    [TestFixture]
    public class AnagramPalindromeCheckerTests
    {
        [Test]
        public void IsAnagramPalindrome_WhenPassedAllCharactersSame_ReturnsTrue()
        {
            //Arrange
            var anagramPalindromeChecker = new AnagramPalindromeChecker();
            var inputString = "aaaaaaaa";
            //Act
            var actualResult = anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_WhenPassedSameCharacterEvenTimesAndOneDifferentCharacter_ReturnsTrue()
        {
            //Arrange
            var anagramPalindromeChecker = new AnagramPalindromeChecker();
            var inputString = "aaaaaaaab";
            //Act
            var actualResult = anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_WhenPassedMoreThanOneDifferentLetter_ReturnsFalse()
        {
            //Arrange
            var anagramPalindromeChecker = new AnagramPalindromeChecker();
            var inputString = "caaaaaaaab";
            //Act
            var actualResult = anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_WhenPassedManyDifferentLetters_ReturnsFalse()
        {
            //Arrange
            var anagramPalindromeChecker = new AnagramPalindromeChecker();
            var inputString = "owefhijpfwai";
            //Act
            var actualResult = anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_DifferentLettersButOneWithNoMatch_ReturnsTrue()
        {
            //Arrange
            var anagramPalindromeChecker = new AnagramPalindromeChecker();
            var inputString = "igdedgide";
            //Act
            var actualResult = anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_PassedNull_ReturnsFalse()
        {
            //Arrange
            var anagramPalindromeChecker = new AnagramPalindromeChecker();
            string inputString = null;
            //Act
            var actualResult = anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void IsAnagramPalindrome_DifferentLettersButOneWithNoMatchAndASpace_ReturnsTrue()
        {
            //Arrange
            var anagramPalindromeChecker = new AnagramPalindromeChecker();
            var inputString = "igded gide";
            //Act
            var actualResult = anagramPalindromeChecker.IsAnagramPalindrome(inputString);
            //Assert
            Assert.IsTrue(actualResult);
        }
    }
}
