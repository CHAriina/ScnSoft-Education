namespace LeetCodeTraining.LongestPalindromicSubstring4
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    string substr = s.Substring(i, j - i);
                    if (IsPalindrome(substr) && substr.Length > result.Length)
                    {
                        result = substr;
                    }
                }
            }

            return result;
        }

        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}