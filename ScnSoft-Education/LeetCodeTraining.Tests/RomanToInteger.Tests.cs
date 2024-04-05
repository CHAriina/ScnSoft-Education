using LeetCodeTraining.RomanTo_Integer12;

namespace LeetCodeTraining.Tests.RomanTo_Integer
{
    public class SolutionTests
    {
        Solution solution = new Solution();
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void TestRomanToInt(string s, int expected)
        {
            int result = solution.RomanToInt(s);
            Assert.Equal(expected, result);
        }
    }
}
