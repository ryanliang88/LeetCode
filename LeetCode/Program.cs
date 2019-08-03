using System;
using System.Linq;

namespace LeetCodeSolutions
{
    public static class Program
    {
        private static void Main()
        {
            /*
            var twoSumAnswer = new TwoSum().Solution(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine(Formatter.Format(twoSumAnswer));
            */
        }
    }

    public static class Formatter
    {
        public static string Format(int[] nums) => $"[{string.Join(", ", nums)}]";
    }
}
