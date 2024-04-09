using LeetCodeTraining.ThreeSumClosest17;

namespace LeetCodeTraining.Tests.ThreeSumClosest
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [InlineData(new int[] { 0, 0, 0 }, 1, 0)]
        [InlineData(new int[] { 1, 1, 1, 1 }, -100, 3)]
        public void TestThreeSumClosest(int[] nums, int target, int expected)
        {
            Solution solution = new Solution();
            int result = solution.ThreeSumClosest(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
