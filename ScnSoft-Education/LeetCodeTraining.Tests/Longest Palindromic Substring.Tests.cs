using LeetCodeTraining.LongestPalindromicSubstring4;
using Xunit;

namespace LongestPalindromicSubstringTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("", "")]
        [InlineData("aaaaa", "aaaaa")]
        public void LongestPalindrome_ValidInput_ReturnsExpectedResult(string input, string expectedResult)
        {
            // Arrange
            var solution = new Solution();
            string result;

            // Act
            result = solution.LongestPalindrome(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}