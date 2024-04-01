using LeetCodeTraining.ReverseInteger7;

namespace LeetCodeTraining.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(1534236469, 0)] // Пример переполнения
        public void TestReverse(int inputNumber, int expected)
        {
            Solution solution = new Solution();
            int result = solution.Reverse(inputNumber);
            Assert.Equal(expected, result);
        }
    }
}