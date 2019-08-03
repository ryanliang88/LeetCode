using LeetCodeSolutions;
using Xunit;

namespace LeetCodeTests
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void Original_Question(int[] nums, int target, int[] expected)
        {
            // Arrange
            var twoSum = new TwoSum();

            // Act
            var answer = twoSum.Solution(nums, target);

            // Assert
            Assert.Equal(answer, expected);
        }
    }
}
