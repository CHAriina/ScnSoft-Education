using LeetCodeTraining.LongestCommonPrefix13;

namespace LeetCodeTraining.Tests.LongestCommonPrefix
{
        public class SolutionTests
        {
            [Theory]
            [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
            [InlineData(new string[] { "dog", "racecar", "car" }, "")]
            public void TestLongestCommonPrefix(string[] input, string expected)
            {
                var solution = new Solution();
                var result = solution.LongestCommonPrefix(input);
                Assert.Equal(expected, result);
            }
        }
}
