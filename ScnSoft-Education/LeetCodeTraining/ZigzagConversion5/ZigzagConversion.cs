using System.Text;

namespace LeetCodeTraining.ZigzagConversion5
{
    public class Solution
    {
        public static string Convert(string inputString, int numRows)
        {
            if (string.IsNullOrEmpty(inputString) || numRows == 1 || inputString.Length <= numRows)
            {
                return inputString;
            }

            string[] zigzagRows = new string[numRows];
            int currentRow = 0;
            int direction = 1;

            foreach (char character in inputString)
            {
                zigzagRows[currentRow] += character;
                currentRow += direction;

                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    direction *= -1;
                }
            }

            StringBuilder resultBuilder = new StringBuilder();
            foreach (string row in zigzagRows)
            {
                resultBuilder.Append(row);
            }

            return resultBuilder.ToString();
        }
    }
}