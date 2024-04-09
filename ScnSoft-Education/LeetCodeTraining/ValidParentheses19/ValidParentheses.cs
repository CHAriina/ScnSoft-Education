namespace LeetCodeTraining.ValidParentheses19
{
    public class Solution
    {
        public bool IsValid(string inputString)
        {
            Stack<char> openBrackets = new Stack<char>();

            foreach (char bracket in inputString)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    openBrackets.Push(bracket);
                }
                else
                {
                    if (openBrackets.Count == 0)
                    {
                        return false;
                    }
                    if (bracket == ')' && openBrackets.Peek() == '(' || bracket == '}' && openBrackets.Peek() == '{' || bracket == ']' && openBrackets.Peek() == '[')
                    {
                        openBrackets.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return openBrackets.Count == 0;
        }
    }
}
