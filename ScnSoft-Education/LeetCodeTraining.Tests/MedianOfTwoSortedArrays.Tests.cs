using LeetCodeTraining.MedianOfTwoSortedArrays6;
namespace LeetCodeTraining.Tests.MedianOfTwoSortedArrays

{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [InlineData(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }, 3.5)]
        public void FindMedianSortedArrays_ValidInput_ReturnsCorrectMedian(int[] nums1, int[] nums2, double expectedMedian)
        {
            // Arrange
            Solution solution = new Solution();
            // Act
            double result = solution.FindMedianSortedArrays(nums1, nums2);

            // Assert
            Assert.Equal(expectedMedian, result);
        }
    }
}
