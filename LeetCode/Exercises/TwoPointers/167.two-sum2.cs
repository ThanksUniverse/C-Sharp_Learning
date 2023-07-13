using System.Collections;
using System.Dynamic;
using System.Globalization;

namespace LeetCode.Exercises
{
    public static partial class Solution
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var hashTable = new Hashtable();

            for (int i = 0; i < numbers.Length; i++)
            {
                int lookValue = target - numbers[i];

                if (hashTable.Contains(lookValue))
                    return new int[] { (int)hashTable[lookValue] + 1, i + 1 };

                if (hashTable.Contains(numbers[i]))
                    continue;
                else
                    hashTable.Add(numbers[i], i);
            }

            return new int[] { 0 };
        }
    }
}
/* 
Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 < numbers.length.

Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.

Your solution must use only constant extra space.
 */