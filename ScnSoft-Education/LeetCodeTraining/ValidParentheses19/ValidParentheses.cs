namespace LeetCodeTraining.ValidParentheses19
{
    public class Solution
    {
        public bool IsValid(string inputString)
        {
            Stack<char> openBrackets = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (char bracket in inputString)
            {
                if (bracketPairs.ContainsKey(bracket))
                {
                    openBrackets.Push(bracket);
                }
                else
                {
                    if (openBrackets.Count == 0 || bracketPairs[openBrackets.Peek()] != bracket)
                    {
                        return false;
                    }
                    openBrackets.Pop();
                }
            }

            return openBrackets.Count == 0;
        }
    }
}