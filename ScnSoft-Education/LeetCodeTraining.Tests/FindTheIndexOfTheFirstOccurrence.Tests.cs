using LeetCodeTraining.FindTheIndexOfTheFirstOccurrence27;

namespace LeetCodeTraining.Tests.FindTheIndexOfTheFirstOccurrence
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("hello", "ll", 2)]
        [InlineData("aaaaa", "b", -1)]
        [InlineData("mississippi", "issip", 4)]
        public void Test_StrStr(string haystack, string needle, int expected)
        {
            // Arrange
            Solution solution = new Solution();
            // Act
            int result = solution.StrStr(haystack, needle);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
