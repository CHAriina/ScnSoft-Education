using LeetCodeTraining.Generate_Parentheses21;

namespace LeetCodeTraining.Tests.Generate_Parentheses21
{
    public class GenerateParenthesesTests
    {
        [Theory]
        [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        [InlineData(1, new string[] { "()" })]
        public void TestGenerateParentheses(int n, string[] expected)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            IList<string> actual = solution.GenerateParenthesis(n);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
