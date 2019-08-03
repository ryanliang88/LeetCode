using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    /**
    * https://leetcode.com/problems/two-sum/
    */

    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            /**
             * Using Dictionary == Hashtable (Dictionary uses Hashtable implementation)
             * Storing data with its values as Keys and its respective indexes as Values
             */
            var dictionary = new Dictionary<int, int>();

            // 0) Iterate through all values
            for (int i = 0; i < nums.Length; i++)
            {
                // 1) Get current value for simplicity and
                int currentValue = nums[i];

                // Determine compliment of the current value
                int complement = target - currentValue;

                // 2a) Check if dictionary contains the compliment
                if (dictionary.ContainsKey(complement))
                {
                    // 3) If it does, get the compliment's index and
                    int j = dictionary[complement];

                    // Return compliment's index first since it was stored first
                    // and then the current index
                    return new int[] { j, i };
                }
                // 2b) If the dictionary doesn't contain the compiment,
                // Check to see if the currentValue is stored instead
                else if (!dictionary.ContainsKey(currentValue))
                {
                    // If not, store it for future pairing
                    dictionary.Add(currentValue, i);
                }
            }

            throw new Exception();
        }
    }
}
