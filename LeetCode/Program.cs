using System;
using System.Linq;

namespace LeetCode
{
    public static class Program
    {
        private static void Main()
        {
            new TwoSum().Solution(new int[] { 2, 7, 11, 15 }, 9).ToList().ForEach(Console.WriteLine);
        }
    }
}
