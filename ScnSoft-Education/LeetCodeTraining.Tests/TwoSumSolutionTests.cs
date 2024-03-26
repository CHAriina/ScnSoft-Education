using Xunit;

using LeetCodeTraining.TwoSum1;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTests
    {
        [Fact]
        public void TwoSum_ArrayWith2Nums()
        {
            // Arrange
            var solution = new TwoSum1.Solution();
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            Assert.Equal(new int[] { 0, 1 }, result);

        }
    }
}