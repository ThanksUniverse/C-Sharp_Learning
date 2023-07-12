using System;
using LeetCode.Exercises;

namespace LeetCode
{
    public class LeetCode
    {
        static void Solved()
        {
            var strings = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            Solution.GroupAnagrams(strings);
        }
        static void Main()
        {
            var nums = new int[] { 1, 1, 1, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3 };
            int k = 2;
            Solution.TopKFrequent(nums, k);
        }
    }
}