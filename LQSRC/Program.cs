using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;
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
            //Console.WriteLine(ContainsNearbyDuplicate(array3, 2));
            //Console.WriteLine(ContainsNearbyDuplicateSliding(array3, 2));
            //Console.WriteLine(MaxConsecutiveAnswers("TTFTTFTT", 1));
            //Console.WriteLine(MaxConsecutiveAnswers("TFF", 1));
            //Console.WriteLine(LongestPalindrome("babad"));
            //Console.WriteLine(Reverse(-123));
            //Console.WriteLine(SearchInsert(array3, 5));
            //Console.WriteLine(PlusOne(array3));
            //string t = "nagaram";
            var array3 = new int[] { 1, 3, 2, 4 };
            //var array3 = new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
            Console.WriteLine(IsMonotonic(array3));
        }

        public static bool IsMonotonic(int[] nums)
        {
            bool increment = false, decrement = false;
            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                int previous = nums[i - 1];
                if (num != previous)
                {
                    if (num > previous)
                        increment = true;
                    else
                        decrement = true;
                }
                if (increment && decrement)
                    return false;
            }
            return true;
        }

        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            int min = arr.Min(), max = arr.Max();
            int n = arr.Length;

            if (max - min == 0)
            {
                return true;
            }

            if ((max - min) % (n - 1) != 0)
                return false;

            int diff = (max - min) / (n - 1);
            var hashSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                if ((arr[i] - min) % diff != 0)
                    return false;

                hashSet.Add(arr[i]);
            }

            return hashSet.Count == n;
        }

        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            int num = digits.Min();


            foreach (var d in newNumber)
                Console.WriteLine(d);

            return newNumber;
        }

        public static void MoveZeroes2(int[] nums)
        {
            int zeroCount = 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (num == 0)
                {
                    zeroCount++;
                }
                else
                {
                    nums[j++] = num;
                }
            }

            for (int i = nums.Length - zeroCount; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            foreach (var n in nums)
                Console.WriteLine(n);
        }

        public static void MoveZeroes3(int[] nums)
        {
            var zeroCount = nums.Count(x => x == 0);
            nums = nums.OrderBy(x => x).Where(y => y > 0).ToArray();

            Array.Resize(ref nums, nums.Length + zeroCount);

            for (int i = nums.Length - zeroCount; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            foreach (var n in nums)
                Console.WriteLine(n);
        }

        public static bool RepeatedSubstringPattern(string s)
        {
            var repeat = s + s;
            Console.WriteLine(repeat);
            Console.WriteLine(repeat.Substring(1, repeat.Length - 2));
            if (repeat.Substring(1, repeat.Length - 2).Contains(s))
                return true;
            return false;
        }

        public static bool IsAnagram2(string s, string t)
        {
            var array0 = s.ToArray();
            var array1 = t.ToArray();

            Array.Sort(array0);
            Array.Sort(array1);

            string a = new(array0);
            string b = new(array1);

            if (a == b)
                return true;

            return false;
        }

        public static int StrStr2(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            else
                return -1;
        }

        public static char FindTheDifference(string s, string t)
        {
            var orderedT = t.ToArray();
            Array.Sort(orderedT);
            var orderedS = s.ToArray();
            Array.Sort(orderedS);

            if (s.Length == 1)
                return s[^1];

            int counter = 0;
            while (counter < t.Length)
            {
                if (s.Length <= counter)
                    return t[counter];
                if (orderedT[counter] != orderedS[counter])
                {
                    return orderedT[counter];
                }
                counter++;
            }

            return '0';
        }

        public static string MergeAlternately(string word1, string word2)
        {
            var bd = new StringBuilder();
            int j = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                char a = word1[i];
                bd.Append(a);
                if (word2.Length > i)
                {
                    char b = word2[i];
                    bd.Append(b);
                }
                j++;
            }

            while (j < word2.Length)
            {
                bd.Append(word2[j++]);
            }

            return bd.ToString();
        }

        public static int Reverse(int x)
        {
            var isNegative = x < 0;
            var array = Math.Abs(x).ToString().ToCharArray();
            Array.Reverse(array);
            var reversedString = new string(array);
            if (!int.TryParse(reversedString, out int returnNumber))
                return 0;
            return isNegative ? returnNumber * -1 : returnNumber;
        }


        public static string LongestPalindrome(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                for (int j = 1; j < s.Length; j++)
                {
                    string reversed = new(s.Reverse().ToArray());
                    string subI = s.Substring(0, j);
                    string subJ = reversed.Substring(i, j);
                    Console.WriteLine("SubI: " + subI + " SubJ: " + subJ);
                    /* if (subI == subJ)
                        return subI; */
                }
            }
            return "";
        }

        public static int MaxConsecutiveAnswers(string answerKey, int k)
        {
            int longestConsecutiveCount = 0; // Maximum number of consecutive 'T's or 'F's
            int left = 0; // Left pointer of the sliding window
            int maxChanges = k; // Maximum changes allowed
            int tCount = 0; // Count of consecutive 'T's
            int fCount = 0; // Count of consecutive 'F's

            for (int i = 0; i < answerKey.Length; i++)
            {
                char letter = answerKey[i];

                // Increment the count of the currenct answer
                if (letter == 'T')
                    tCount++;
                else
                    fCount++;

                // If the number of changes needed exceeds the maximum changes allowed, move he left pointer and update the counts
                while (Math.Min(tCount, fCount) > maxChanges)
                {
                    char leftAnswer = answerKey[left];

                    if (leftAnswer == 'T')
                        tCount--;
                    else
                        fCount++;

                    left++;
                }

                // Update the longese consecutive count
                longestConsecutiveCount = Math.Max(longestConsecutiveCount, i - left + 1);
            }
            return longestConsecutiveCount;
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

        public static int SearchInsert(int[] nums, int target)
        {
            if (target == 0)
                return 0;
            if (!nums.Contains(target))
            {
                int first = nums.OrderBy(num => Math.Abs(num - target)).First();
                int it = Array.LastIndexOf(nums, first);
                Console.WriteLine($"{first} && {target}");
                if (first > target)
                    return it;
                else
                    return it + 1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (num == target)
                    return i;
            }
            return 0;
        }

        public static int FindMaxSumArray(int[] nums, int k)
        {
            int maxValue = int.MinValue;
            int currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if (i >= k - 1)
                {
                    maxValue = Math.Max(maxValue, currentSum);
                    currentSum -= nums[i - (k - 1)];
                }
            }
            return maxValue;
        }

        public static int FindMaxSumArray2(int[] nums, int k)
        {
            int maxValue = int.MinValue;
            int currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if (i >= k - 1)
                {
                    maxValue = Math.Max(maxValue, currentSum);
                    currentSum -= nums[i - (k - 1)];
                }
            }
            return maxValue;
        }

        public static int LengthOfLastWord(string s)
        {
            var newLine = s.Trim();
            var newString = newLine.Split();
            return newString[newString.Length - 1].Length;
        }

        public static int RemoveDuplicates()
        {
            int[] someTable = new int[] { 0, 0, 1, 1, 1, 2, 3, 3, 4 };

            var hash = new HashSet<int>();
            int j = 0;
            for (int i = 0; i < someTable.Length; i++)
            {
                int num = someTable[i];
                if (!hash.Contains(num))
                {
                    hash.Add(num);
                    someTable[j++] = num;
                }
            }

            foreach (var num in someTable)
                Console.WriteLine(num);

            return j;
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
}