namespace LeetCodeTraining.LongestCommonPrefix13
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] inputStrings)
        {
            if (inputStrings == null || inputStrings.Length == 0)
            {
                return string.Empty;
            }

            string currentPrefix = inputStrings[0];
            for (int i = 1; i < inputStrings.Length; i++)
            {
                while (inputStrings[i].IndexOf(currentPrefix) != 0)
                {
                    currentPrefix = currentPrefix.Substring(0, currentPrefix.Length - 1);
                    if (currentPrefix.Length == 0)
                    {
                        return string.Empty;
                    }
                }
            }

            return currentPrefix;
        }
    }
}
