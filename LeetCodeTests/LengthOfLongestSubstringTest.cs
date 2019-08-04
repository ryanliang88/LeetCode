using Xunit;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    public class LengthOfLongestSubstringTest
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void Original_Questions(string s, int expected)
        {
            // Arrange
            var lengthOfLongestString = new LengthOfLongestSubstring();

            // Act
            var actual = lengthOfLongestString.Solution(s);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
