using LeetCodeTraining.LongestPalindromicSubstring4;
namespace LongestPalindromicSubstringTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("", "")]
        [InlineData("aaaaa", "aaaaa")]
        public void LongestPalindromeResult(string input, string expectedResult)
        {
            // Arrange
            var solution = new Solution();
            string result;

            // Act
            result = Solution.LongestPalindrome(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}