using LeetCodeTraining.LongestSubstringWithoutRepeating3;

namespace LeetCodeTraining.Tests
{
    public class LongestSubstring
    {
        [Fact]
        public void LengthOfLongestSubstring_Test()
        {
            // Arrange
            string input1 = "abcabcbb";
            string input2 = "bbbbb";
            string input3 = "pwwkew";

            // Act
            int result1 = Solution.LengthOfLongestSubstring(input1);
            int result2 = Solution.LengthOfLongestSubstring(input2);
            int result3 = Solution.LengthOfLongestSubstring(input3);

            // Assert
            Assert.Equal(3, result1); // "abc"
            Assert.Equal(1, result2); // "b"
            Assert.Equal(3, result3); // "wke"
        }
    }
}