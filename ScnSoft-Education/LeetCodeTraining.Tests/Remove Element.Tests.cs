using LeetCodeTraining.RemoveElement26;

namespace LeetCodeTraining.Tests.RemoveElement
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 }, 5)]
        public void RemoveElement_Test(int[] nums, int val, int[] expectedArray, int expectedLength)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.RemoveElement(nums, val);

            // Assert
            Assert.Equal(expectedLength, result);
            Assert.Equal(expectedArray, nums[0..result]);
        }
    }
}
