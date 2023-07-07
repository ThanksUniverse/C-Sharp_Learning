﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Random
{
    partial class Program
    {
        static void Main()
        {
            /*  int[] array = new int[] { 1, -2, 3, 4, -1, 5 };
             int k = 3;

             int maxSum = SlidingWindow(array, k);

             Console.WriteLine(maxSum); */

            /* var nums = new int[] { 3,2,2,3 };
            RemoveElement(nums, 3); */

            /* Console.WriteLine(StrStr("leetcode", "leeto"));
            Console.WriteLine(StrStr("leetcode", "leet"));
            Console.WriteLine(StrStr("aaapedro", "pedro")); */
            /* var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20 };
            Console.WriteLine(FirstMissingPositive(array));
            var array2 = new int[] { 3, 4, -1, 1 };
            Console.WriteLine(FirstMissingPositive(array2)); 
            Console.WriteLine(MinSubArrayLen(4, array3)); */
            //Console.WriteLine(FirstMissingPositive(array3));
            var array3 = new int[] { 1, 2, 3, 1, 2, 3 };
            Console.WriteLine(ContainsNearbyDuplicate(array3, 2));
            Console.WriteLine(ContainsNearbyDuplicateSliding(array3, 2));
        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]) && Math.Abs(dictionary[nums[i]] - i) <= k)
                {
                    return true;
                }
                dictionary[nums[i]] = i;
            }
            return false;
        }

        public static bool ContainsNearbyDuplicateSliding(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                while (j < nums.Length && Math.Abs(i - j) <= k)
                {
                    if (nums[i] == nums[j])
                        return true;
                    j++;
                }
            }
            return false;
        }

        public static int FirstMissingPositive(int[] nums)
        {
            var array = nums.Where(y => y > 0).OrderBy(x => x).Distinct().ToArray();
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                j++;
                if (num != j)
                    return j;

                if (i == array.Length - 1)
                    return num + 1;
            }

            return 1;
        }

        private static int GetMinimumNumber(int[] nums, int num)
        {
            int counter = num - 1;
            while (!nums.Contains(counter))
            {
                Console.WriteLine(counter);
                if (nums.Contains(counter))
                    return counter;

                counter--;

                if (counter == 0)
                    return 1;
            }
            return counter + 1;
        }

        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            else
                return -1;
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            foreach (int num in nums)
            {
                if (num != val)
                {
                    nums[j++] = num;
                }
            }
            foreach (var a in nums)
                Console.WriteLine(a);
            return j;
        }

        public static int SlidingWindow(int[] nums, int range)
        {
            int windowSum = 0;
            int maxSum = 0;
            int start = 0;

            for (int end = 0; end < nums.Length; end++)
            {
                windowSum += nums[end];

                if (end - start + 1 > range)
                {
                    windowSum -= nums[start];
                    start++;
                }

                if (end - start + 1 == range)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                }
            }

            return maxSum;
        }

        public static int MinSubArrayLen(int target, int[] nums)
        {
            int len = 0;              // Current subarray length
            int val = int.MaxValue;   // Minimum subarray length that meets the target
            int num = 0;              // Sum of current subarray elements

            for (int i = 0; i < nums.Length; i++)
            {
                num += nums[i];   // Add the current element to the sum of the subarray

                while (num >= target)   // If the sum is greater than or equal to the target
                {
                    val = Math.Min(val, i - len + 1);   // Update the minimum subarray length
                    num -= nums[len];                   // Subtract the leftmost element from the subarray
                    len++;                              // Increment the subarray length by moving the left pointer
                }
            }

            return val != int.MaxValue ? val : 0;   // Return the minimum subarray length or 0 if not found
        }


        public static int LongestSubarray(int[] nums)
        {
            int zeroCount = 0;
            int longestWindow = 0;
            // Left end of the Window
            int start = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                zeroCount += (nums[i] == 0 ? 1 : 0);

                while (zeroCount > 1)
                {
                    zeroCount -= (nums[start] == 0 ? 1 : 0);
                    start++;
                }

                longestWindow = Math.Max(longestWindow, i - start);
            }

            return longestWindow;
        }

        public static int SingleNumber(int[] nums)
        {
            var it = nums.Where(x => nums.Count(y => y == x) == 1).Distinct();
            return it.ToArray()[0];
        }

        public static int RemoveDuplicates()
        {
            int[] someTable = new int[] { 0, 0, 1, 1, 1, 2, 3, 3, 4 };

            someTable = someTable.OrderBy(x => x).Distinct().ToArray();

            foreach (int num in someTable)
                Console.WriteLine(num);

            return 0;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (string.IsNullOrEmpty(prefix))
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }

        public static int FirstMissing(int[] nums)
        {
            int smallest = 999, highest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int nowN = nums[i];
                if (smallest > nowN)
                {
                    smallest = nowN;
                }
                if (highest < nowN)
                    highest = nowN;
            }
            if (smallest <= 1)

            {
                Console.WriteLine("B");
                smallest = highest - 1;
            }
            smallest = Math.Max(0, smallest);
            return smallest;
        }

        public static bool IsAnagram(string s, string t)
        {
            char[] it = s.ToCharArray();
            char[] ito = t.ToCharArray();

            Array.Sort(it);
            Array.Sort(ito);

            string a = new(it);
            string b = new(ito);

            Console.WriteLine(a);
            Console.WriteLine(b);




            return true;
        }

        public static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        public static bool Palindrome(string s)
        {
            string finalLine;
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(c);
                }
            }
            finalLine = sb.ToString().ToLower();

            string reverse = new(finalLine.Reverse().ToArray());
            if (finalLine == reverse)
                return true;
            else
                return false;
        }

        public static bool CheckStraightLine(int[][] coordinates)
        {
            int idx0;
            int idx1;
            int chance = 0;
            for (int i = 0; i < coordinates[0].Length; i++)
            {
                for (int j = 0; j < coordinates[1].Length; j++)
                {
                    idx0 = coordinates[i][0];
                    idx1 = coordinates[i][1];
                    if (chance > 2)
                        return false;
                    if (idx0 == idx1 || idx0 + 1 != idx1)
                    {
                        chance++;
                    }
                }
            }
            Console.WriteLine("tru");
            return true;
        }

        public static bool IsPalindrome(int x)
        {
            string y = x.ToString();
            y = new(y.Reverse().ToArray());
            if (y == x.ToString()) return true;
            return false;
        }

        public static int RomanToInt(string s)
        {
            int value = 0;


            int letterCount = 0;

            while (letterCount < s.Length)
            {
                char lastLetter = '1';
                if (letterCount - 1 >= 0)
                {
                    lastLetter = s[letterCount - 1];
                }
                char letter = s[letterCount];
                int number = GetNumber(letter.ToString(), lastLetter.ToString());
                value += number;
                letterCount++;
            }

            Console.WriteLine(value);
            return 0;
        }

        private static int GetNumber(string s, string last)
        {
            int value = 0;
            string total = last + s;
            switch (s)
            {
                case "I":
                    value += 1;
                    break;
                case "V":
                    value += 5;
                    break;
                case "X":
                    value += 10;
                    break;
                case "L":
                    value += 50;
                    break;
                case "C":
                    value += 100;
                    break;
                case "D":
                    value += 500;
                    break;
                case "M":
                    value += 1000;
                    break;
                default:
                    break;
            }
            Console.WriteLine(total);
            if (total == "IV" || total == "IX")
            {
                value -= 2;
            }
            else if (total == "XL" || total == "XC")
            {
                value -= 20;
            }
            else if (total == "CD" || total == "CM")
            {
                value -= 200;
            }
            return value;
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mergedList = new List<int>();
            mergedList.AddRange(nums1);
            mergedList.AddRange(nums2);

            var orderedList = mergedList.OrderBy(num => num).ToList();

            double median = 0;

            int halfSize = Math.Max(0, orderedList.Count / 2 - 1);
            if (orderedList.Count % 2 == 0)
            {
                median = orderedList[halfSize] + orderedList[halfSize + 1];
                median /= 2;
            }
            else
            {
                if (orderedList[halfSize] + 1 <= orderedList.Count && orderedList.Count > 1)
                {
                    median = orderedList[halfSize + 1];
                }
                else
                {
                    if (orderedList.Count > 1)
                    {
                        median = orderedList[halfSize + 1];
                    }
                    else
                        median = orderedList[halfSize];
                }
            }
            Console.WriteLine(median);
            return median;
        }

        [System.Text.RegularExpressions.GeneratedRegex("[^a-zA-Z0-9]")]
        private static partial System.Text.RegularExpressions.Regex MyRegex();
    }
    public static class Solution
    {
        public static bool ValidParenthesis(string s)
        {
            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            return s.Length == 0;
        }
        public static int LengthOfLongestSubstring(string s)
        {
            var charLists = new HashSet<string>();
            var chars = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0 + i; j < s.Length; j++)
                {
                    char letter = s[j];
                    Console.WriteLine($"J:{j}//I:{i}::{letter}");
                    if (!chars.Contains(letter))
                    {
                        Console.WriteLine(letter);
                        chars.Add(letter);
                    }
                    else
                    {
                        var line = new StringBuilder();
                        foreach (var let in chars)
                            line.Append(let);

                        Console.WriteLine(line.ToString());
                        charLists.Add(line.ToString());
                        chars.Clear();
                        break;
                    }
                }
            }

            if (chars.Count > 0)
            {
                var line = new StringBuilder();
                foreach (var let in chars)
                    line.Append(let);
            }


            int highest = 0;
            foreach (var component in charLists)
            {
                if (highest < component.Length)
                    highest = component.Length;

            }
            return highest;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
    }
}