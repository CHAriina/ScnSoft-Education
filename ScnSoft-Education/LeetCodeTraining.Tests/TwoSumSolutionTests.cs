using LeetCodeTraining.TwoSum1;
namespace LeetCodeTraining.Tests.TwoSum
{
    public class TwoSumSolutionTests
    {
        [Fact]
        public void TwoSum_ArrayWith2Nums()
        {
            // Arrange
            var solution = new TwoSumSolution();
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            // Act
            var result = solution.Resolve(nums, target);

            // Assert
            Assert.Equal([0, 1], result);
        }

        [Fact]
        public void NotfoundItems()
        {
            // Arrange
            var solution = new TwoSumSolution();
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 10;

            // Act
            var result = solution.Resolve(nums, target);

            // Assert
            Assert.Null(result);
        }
    }
}