﻿using System;
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

    }
}