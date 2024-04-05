using LeetCodeTraining.ThreeSum14;

namespace LeetCodeTraining.ThreeSum14
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { -1, 0, 1, 2, -1, -4 }, new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 })]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0 })]
        public void ThreeSum_Test(int[] nums, params int[][] expected)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            IList<IList<int>> result = solution.ThreeSum(nums);

            // Assert
            Assert.Equal(expected.Length, result.Count);

            foreach (var tuple in expected)
            {
                Assert.Contains(new List<int>(tuple), result);
            }
        }
    }
}
