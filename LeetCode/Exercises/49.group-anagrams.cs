namespace LeetCode.Exercises
{
    public static partial class Solution
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagramDic = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string originalString = strs[i];
                string sortedString = string.Concat(originalString.OrderBy(s => s));
                if (!anagramDic.TryGetValue(sortedString, out var anagrams))
                {
                    anagrams = new List<string>();
                    anagramDic[sortedString] = anagrams;
                }
                anagrams.Add(originalString);
            }

            return anagramDic.Values.ToList();
        }
    }
}