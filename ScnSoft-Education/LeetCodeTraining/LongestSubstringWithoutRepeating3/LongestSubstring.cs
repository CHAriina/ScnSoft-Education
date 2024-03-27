namespace LeetCodeTraining.LongestSubstringWithoutRepeating3
{
    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            HashSet<char> set = [];
            int start = 0, end = 0;

            while (end < s.Length)
            {
                if (!set.Contains(s[end]))
                {
                    set.Add(s[end]);
                    maxLength = Math.Max(maxLength, end - start + 1);
                    end++;
                }
                else
                {
                    set.Remove(s[start]);
                    start++;
                }
            }

            return maxLength;
        }
    }
}