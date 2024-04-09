namespace LeetCodeTraining.ThreeSumClosest17
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = int.MaxValue;
            int minDiff = int.MaxValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int firstNum = nums[i];
                int leftPointer = i + 1;
                int rightPointer = nums.Length - 1;

                while (leftPointer < rightPointer)
                {
                    int currentSum = firstNum + nums[leftPointer] + nums[rightPointer];
                    int currentDiff = Math.Abs(currentSum - target);

                    if (currentDiff < minDiff)
                    {
                        minDiff = currentDiff;
                        closestSum = currentSum;
                    }

                    if (currentSum < target)
                    {
                        leftPointer++;
                    }
                    else
                    {
                        rightPointer--;
                    }
                }
            }

            return closestSum;
        }
    }
}
