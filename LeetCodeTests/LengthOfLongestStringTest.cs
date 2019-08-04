using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    public class LengthOfLongestStringTest
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void Original_Question(string s, int expected)
        {
            // Arrange
            var lengthOfLongestString = new LengthOfLongestString();

            // Act
            var actual = lengthOfLongestString.Solution(s);

            // Assert
            Assert.Equal(expected, actual);
        }

        /**
        Thoughts:

        pointer1 loops through the string
        pointer2 starts from pointer1 and stops once I get a letter already in my character array

        optimization:
        pointer1 can jump to pointer2 once pointer2 stops
        pointer1 can exit loop early once rest of string is shorter than maxSubstring

        */
    }
}
