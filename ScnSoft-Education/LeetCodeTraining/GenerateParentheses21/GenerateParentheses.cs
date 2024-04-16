namespace LeetCodeTraining.Generate_Parentheses21
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Generate(result, "", 0, 0, n);
            {
                return result;
            }
        }

        private void Generate(List<string> result, string current, int open, int close, int max)
        {
            if (current.Length == 2 * max)
            {
                result.Add(current);
                {
                    return;
                }
            }

            if (open < max)
            {
                Generate(result, current + "(", open + 1, close, max);
            }

            if (close < open)
            {
                Generate(result, current + ")", open, close + 1, max);
            }
        }
    }


}
