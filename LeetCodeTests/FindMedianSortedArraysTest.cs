using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    public class FindMedianSortedArraysTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, }, new int[] { 3, 4, }, 2.5)]
        [InlineData(new int[] { 1, 3, }, new int[] { 2, }, 2.0)]
        public static void Original_Question(int[] nums1, int[] nums2, double expected)
        {
            // Arrange
            var findMedianSortedArrays = new FindMedianSortedArrays();

            // Act
            var actual = findMedianSortedArrays.Solution(nums1, nums2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
