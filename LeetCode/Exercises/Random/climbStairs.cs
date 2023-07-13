using System.Dynamic;

namespace LeetCode.Exercises
{
    public static partial class Solution
    {
        public static int ClimbStairs(int n)
        {
            int one = 1, two = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = one;
                one += two;
                two = temp;
            }
            Console.WriteLine(one);
            return one;
        }
    }
}