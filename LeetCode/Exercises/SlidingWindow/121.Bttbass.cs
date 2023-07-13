using System.Dynamic;

namespace LeetCode.Exercises
{
    public static partial class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                int price = prices[i];
                minPrice = Math.Min(minPrice, price);
                maxProfit = Math.Max(maxProfit, price - minPrice);
            }

            return maxProfit;
        }
    }
}