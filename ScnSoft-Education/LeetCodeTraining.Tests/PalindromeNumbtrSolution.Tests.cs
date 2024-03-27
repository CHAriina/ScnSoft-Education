using LeetCodeTraining.PalindromeNumber2;

namespace PalindromeNumberTests
{
    public class PalindromeNumberSolutionTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(12321, true)]
        public void IsPalindrome_ValidInput_ReturnsExpectedResult(int input, bool expectedResult)
        {
            // Arrange
            bool result;

            // Act
            result = PalindromeNumberSolution.IsPalindrome(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}