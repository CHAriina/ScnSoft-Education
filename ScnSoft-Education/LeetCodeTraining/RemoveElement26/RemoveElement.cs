namespace LeetCodeTraining.RemoveElement26
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int nonValElementsCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[nonValElementsCount] = nums[i];
                    nonValElementsCount++;
                }
            }

            return nonValElementsCount;
        }
    }
}
