using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    /**
     * https://leetcode.com/problems/longest-substring-without-repeating-characters/
     * Understood
     */

    public class LengthOfLongestSubstring
    {
        public int Solution(string str)
        {
            // Size of (sliding window, the substring)
            int maxSubstringLength = 0;

            // Dictionary == Hashtable holds the index of last occurrence of the letter (e.g. when you see w in 'pw', set table[w] to 1)
            var lastOccurrenceIndexTableOfLetter = new Dictionary<char, int>();

            // left    is left  index of sliding window
            // current is right index of sliding window - the current value / letter to be evaluated
            // Note: Math.Max works like an IF statement

            for (int left = 0, currentIndex = 0; currentIndex < str.Length; currentIndex++)
            {
                var letter = str[currentIndex];

                // Set to current letter IF seen essentially
                // value is initialized and set to 0; if statement can be mostly disregarded
                // (e.g. when you already went through 'pw' and you see the next 'w', set left to index1 + 1 = 2 since you can discard pw and start from the next 'w')
                if (lastOccurrenceIndexTableOfLetter.TryGetValue(letter, out int value))
                {
                    left = Math.Max(left, value + 1);
                }

                // Set to window size ('pw' = index1 - index0 + 1 = 2) IF larger
                maxSubstringLength = Math.Max(maxSubstringLength, currentIndex - left + 1);

                // Sets last occurrence of letter in table
                lastOccurrenceIndexTableOfLetter[letter] = currentIndex;
            }

            return maxSubstringLength;
        }
    }
}
