using LeetCodeTraining.Generate_Parentheses21;

namespace LeetCodeTraining.Tests.Generate_Parentheses21
{
    public class SolutionTests
    {
        private Solution solution;

        public SolutionTests()
        {
            solution = new Solution();
        }

        [Theory]
        [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        [InlineData(1, new string[] { "()" })]
        [InlineData(0, new string[] { "" })]
        public void TestGenerateParenthesis(int n, string[] expected)
        {
            IList<string> result = solution.GenerateParenthesis(n);
            Assert.Equal(expected, result);
        }
    }
}
