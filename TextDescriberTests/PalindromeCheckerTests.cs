﻿using NUnit.Framework;
using TextDescriberDomain;

namespace TextDescriberTests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        [Test]
        public void Describe_WhenPassedValidPalindrome_ReturnsTextPalindrome()
        {
            //Arrange
            var textDescriber = new PalindromeChecker();
            var expectedResult = "palindrome";
            var inputString = "anna";
            //Act
            var actualResult = textDescriber.IsPalindrome(inputString);
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }


    }
}