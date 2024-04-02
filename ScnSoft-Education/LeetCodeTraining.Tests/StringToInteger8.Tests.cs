using LeetCodeTraining.StringToInteger8;
namespace LeetCodeTraining.Tests
{
    public class MyAtoiTests
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        public void TestMyAtoi(string s, int expected)
        {
            var solution = new Solution();
            int result = solution.MyAtoi(s);
            Assert.Equal(expected, result);
        }
    }
}
