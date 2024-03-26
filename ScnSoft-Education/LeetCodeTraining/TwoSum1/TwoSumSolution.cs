namespace LeetCodeTraining.TwoSum1
{
    //https://leetcode.com/problems/two-sum/?source=submission-ac
    public class TwoSumSolution
    {
        public int[]? Resolve(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }

            return null;
        }
    }
}