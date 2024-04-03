using LeetCodeTraining.PalindromeNumber2;
namespace LeetCodeTraining.Tests.PalindromeNumber
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
            // Act
            bool result = PalindromeNumberSolution.IsPalindrome(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}