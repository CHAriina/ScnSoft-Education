using LeetCodeTraining.ZigzagConversion5;
namespace LeetCodeTraining.Tests.ZigzagConversion
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Convert_ValidInput_ReturnsExpectedResult(string input, int numRows, string expected)
        {
            // Arrange
            string result;

            // Act
            result = Solution.Convert(input, numRows);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Convert_NullInput_ReturnsNull()
        {
            // Arrange
            string input = null;

            // Act
            string result = Solution.Convert(input, 3);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Convert_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string input = "";

            // Act
            string result = Solution.Convert(input, 3);

            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Convert_NumRowsEqualOne_ReturnsInputString()
        {
            // Arrange
            string input = "HELLO";
            int numRows = 1;

            // Act
            string result = Solution.Convert(input, numRows);

            // Assert
            Assert.Equal(input, result);
        }
    }
}