using LeetCodeTraining.ValidParentheses19;

namespace LeetCodeTraining.Tests.ValidParentheses19
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        [InlineData("", true)]
        public void TestIsValid(string inputString, bool expected)
        {
            Solution solution = new Solution();

            bool result = solution.IsValid(inputString);

            Assert.Equal(expected, result);
        }
    }
}
