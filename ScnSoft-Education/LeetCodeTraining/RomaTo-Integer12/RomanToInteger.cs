namespace LeetCodeTraining.RomanTo_Integer12
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int result = 0;
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                while (index < values.Length)
                {
                    if (i + symbols[index].Length <= s.Length && s.Substring(i, symbols[index].Length) == symbols[index])
                    {
                        result += values[index];
                        i += symbols[index].Length;
                    }
                    else
                    {
                        index++;
                    }
                }
            }

            return result;
        }
    }
}
