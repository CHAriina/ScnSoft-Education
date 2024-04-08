using LeetCodeTraining.FourSum16;

namespace LeetCodeTraining.Tests.FourSum16
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 0, -1, 0, -2, 2 }, 0, new int[] { -2, -1, 1, 2 }, new int[] { -2, 0, 0, 2 }, new int[] { -1, 0, 0, 1 })]
        [InlineData(new int[] { 2, 2, 2, 2, 2 }, 8, new int[] { 2, 2, 2, 2 })]
        public void FourSum_Test(int[] nums, int target, params int[][] expected)
        {
            // Arrange
            Solution solution = new Solution();
            // Act
            IList<IList<int>> result = solution.FourSum(nums, target);

            // Assert
            Assert.Equal(expected.Length, result.Count);

            foreach (var tuple in expected)
            {
                Assert.Contains(new List<int>(tuple), result);
            }
        }
    }
}
