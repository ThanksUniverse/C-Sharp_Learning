namespace LeetCode.Exercises
{
    public static partial class Solution
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var answer = new List<int>();
            var ordered = nums
                .GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .Distinct()
                .ToList();

            int counter = 0;
            while (answer.Count < k)
            {
                int value = ordered[counter];
                answer.Add(value);
                counter++;
            }

            return answer.ToArray();
        }
    }
}