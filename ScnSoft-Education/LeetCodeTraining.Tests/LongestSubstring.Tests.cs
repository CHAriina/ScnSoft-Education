using LeetCodeTraining.LongestSubstringWithoutRepeating3;

namespace LeetCodeTraining.Tests
{
    public class LongestSubstring
    {
        [Theory]
        [InlineData("abcabcbb", 3)] // "abc"
        [InlineData("bbbbb", 1)] // "b"
        [InlineData("pwwkew", 3)] // "wke"
        public void LengthOfLongestSubstring_Test(string input, int expected)
        {
            // Act
            int result = Solution.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}