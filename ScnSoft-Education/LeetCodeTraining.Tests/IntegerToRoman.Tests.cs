using LeetCodeTraining.IntegertToRoman11;

namespace LeetCodeTraining.Tests.IntegertToRoman
{
    public class SolutionTestsIntegertToRomanv
    {
        [Theory]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void IntToRoman_WhenCalled_ReturnsCorrectRomanNumeral(int num, string expected)
        {
            // Arrange
            var solution = new Solution();
            // Act
            string result = solution.IntToRoman(num);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
