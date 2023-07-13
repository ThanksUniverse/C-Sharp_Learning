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
            var nums = new int[] { 1, 1, 1, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3 };
            int k = 2;
            Solution.TopKFrequent(nums, k);
            var nums2 = new int[] { 4, 5, 3, 2 };
            Solution.ProductExceptSelf(nums2);
            var nums5 = new int[] { 0, -1 };
            Solution.LongestConsecutive(nums5);
            var nums8 = new int[] { 2, 3, 4 };
            foreach (var it in Solution.TwoSum(nums8, 6))
            {
                Console.WriteLine(it);
            }
        }
        static void Main()
        {
            var nums9 = new int[] { 7, 1, 5, 3, 6, 4 };
            Solution.MaxProfit(nums9);
        }
    }
}