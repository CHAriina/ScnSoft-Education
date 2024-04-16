using LeetCodeTraining.RemoveDuplicatesFromSortedArray25;

namespace LeetCodeTraining.Tests.RemoveDuplicatesFromSortedArray
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        public void RemoveDuplicates_ShouldReturnCorrectResult(int[] input, int expectedUniqueCount, int[] expectedUniqueElements)
        {
            // Arrange
            var solution = new Solution();

            // Act
            int uniqueCount = solution.RemoveDuplicates(input);

            // Assert
            Assert.Equal(expectedUniqueCount, uniqueCount);

            for (int i = 0; i < uniqueCount; i++)
            {
                Assert.Equal(expectedUniqueElements[i], input[i]);
            }
        }
    }
}
