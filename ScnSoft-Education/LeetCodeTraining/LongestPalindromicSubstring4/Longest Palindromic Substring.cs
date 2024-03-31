namespace LeetCodeTraining.LongestPalindromicSubstring4
{
    public class Solution
    {
        public static string LongestPalindrome(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return string.Empty;
            }

            string longestPalindromeSubstr = string.Empty;

            for (int firstIndex = 0; firstIndex < inputString.Length; firstIndex++)
            {
                for (int secondIndex = firstIndex + 1; secondIndex <= inputString.Length; secondIndex++)
                {
                    string currentSubstring = inputString.Substring(firstIndex, secondIndex - firstIndex);
                    if (IsPalindrome(currentSubstring) && currentSubstring.Length > longestPalindromeSubstr.Length)
                    {
                        longestPalindromeSubstr = currentSubstring;
                    }
                }
            }

            return longestPalindromeSubstr;
        }

        public static bool IsPalindrome(string inputString)
        {
            int firstIndex = 0, secondIndex = inputString.Length - 1;
            while (firstIndex < secondIndex)
            {
                if (inputString[firstIndex] != inputString[secondIndex])
                {
                    return false;
                }

                firstIndex++;
                secondIndex--;
            }

            return true;
        }
    }
}