using LeetCodeTraining.ContainerWithMostWater10;
namespace LeetCodeTraining.Tests.ContainerWithMostWater
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 20)]
        [InlineData(new int[] { 4, 4, 4, 4, 4 }, 16)]
        public void MaxArea_ReturnsCorrectMaxArea(int[] height, int expected)
        {
            // Arrange
            Solution solution = new Solution();
            // Act
            int maxArea = solution.MaxArea(height);

            // Assert
            Assert.Equal(expected, maxArea);
        }
    }
}
