using LeetCodeSolutions;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTests
{
    public class AddTwoNumbersTest
    {
        [Theory]
        [MemberData(nameof(AddTwoNumbersData.Data), MemberType = typeof(AddTwoNumbersData))]
        public void Original_Question(ListNode l1, ListNode l2, ListNode expected)
        {
            // Arrange

            // Act
            ListNode answer = l1 + l2;

            // Assert
            Assert.Equal(answer, expected);
        }
    }

    public class AddTwoNumbersData
    {
        public static readonly int[] l1Data = { 2, 4, 3 };
        public static readonly int[] l2Data = { 5, 6, 4 };
        public static readonly int[] answerData = { 7, 0, 8 };

        static AddTwoNumbersData()
        {
            Data = new List<object[]> {
                new object[] { new ListNode(l1Data), new ListNode(l2Data), new ListNode(answerData) }
            };
        }

        public static IEnumerable<object[]> Data { get; set; }
    }
}
