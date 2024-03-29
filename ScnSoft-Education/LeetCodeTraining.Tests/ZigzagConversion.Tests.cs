using LeetCodeTraining.ZigzagConversion5;
namespace ZigzagConversionTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Convert_ValidInput_ReturnsExpectedResult(string s, int numRows, string expectedResult)
        {
            // Arrange, Act, Assert
            Assert.Equal(expectedResult, Solution.Convert(s, numRows));
        }
    }
}