
namespace LeetCodeTraining.ZigzagConversion5
{
    public class Solution
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
            {
                return s;
            }

            string[] rows = new string[numRows];
            int currentRow = 0;
            int direction = 1;

            foreach (char c in s)
            {
                rows[currentRow] += c;
                currentRow += direction;

                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    direction *= -1;
                }
            }

            string result = "";
            foreach (string row in rows)
            {
                result += row;
            }

            return result;
        }
    }
} 