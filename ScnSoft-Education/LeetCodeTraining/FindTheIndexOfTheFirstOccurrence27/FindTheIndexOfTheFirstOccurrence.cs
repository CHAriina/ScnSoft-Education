namespace LeetCodeTraining.FindTheIndexOfTheFirstOccurrence27
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;

            for (int counter = 0; counter <= haystack.Length - needle.Length; counter++)
            {
                if (haystack.Substring(counter, needle.Length) == needle)
                {
                    return counter;
                }
            }

            return -1;
        }
    }
}
