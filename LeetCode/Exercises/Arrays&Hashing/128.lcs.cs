using System.Dynamic;

namespace LeetCode.Exercises
{
    public static partial class Solution
    {
        public static int LongestConsecutive(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);
            int maxLength = 0;

            foreach (int num in nums)
            {
                if (hashSet.Contains(num - 1)) continue;

                int length = 0;
                while (hashSet.Contains(num + length)) length++;
                    maxLength = Math.Max(maxLength, length);
            }

            return maxLength;
        }
    }
}