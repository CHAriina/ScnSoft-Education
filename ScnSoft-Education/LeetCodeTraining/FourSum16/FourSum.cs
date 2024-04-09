namespace LeetCodeTraining.FourSum16
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            for (int firstNumIndex = 0; firstNumIndex < nums.Length - 3; firstNumIndex++)
            {
                if (firstNumIndex > 0 && nums[firstNumIndex] == nums[firstNumIndex - 1])
                {
                    continue;
                }

                for (int secondNumIndex = firstNumIndex + 1; secondNumIndex < nums.Length - 2; secondNumIndex++)
                {
                    if (secondNumIndex > firstNumIndex + 1 && nums[secondNumIndex] == nums[secondNumIndex - 1])
                    {
                        continue;
                    }

                    int leftPointer = secondNumIndex + 1;
                    int rightPointer = nums.Length - 1;

                    while (leftPointer < rightPointer)
                    {
                        long sum = (long)nums[firstNumIndex] + nums[secondNumIndex] + nums[leftPointer] + nums[rightPointer];

                        if (sum == target)
                        {
                            result.Add(new List<int> { nums[firstNumIndex], nums[secondNumIndex], nums[leftPointer], nums[rightPointer] });

                            while (leftPointer < rightPointer && nums[leftPointer] == nums[leftPointer + 1])
                            {
                                leftPointer++;
                            }

                            while (leftPointer < rightPointer && nums[rightPointer] == nums[rightPointer - 1])
                            {
                                rightPointer--;
                            }

                            leftPointer++;
                            rightPointer--;
                        }
                        else if (sum < target)
                        {
                            leftPointer++;
                        }
                        else
                        {
                            rightPointer--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
