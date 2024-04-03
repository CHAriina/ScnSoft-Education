namespace LeetCodeTraining.MedianOfTwoSortedArrays6
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int[] merged = new int[length1 + length2];

            int index1 = 0, index2 = 0, indexMerged = 0;
            while (index1 < length1 && index2 < length2)
            {
                if (nums1[index1] < nums2[index2])
                {
                    merged[indexMerged++] = nums1[index1++];
                }
                else
                {
                    merged[indexMerged++] = nums2[index2++];
                }
            }

            while (index1 < length1)
            {
                merged[indexMerged++] = nums1[index1++];
            }

            while (index2 < length2)
            {
                merged[indexMerged++] = nums2[index2++];
            }

            if ((length1 + length2) % 2 == 0)
            {
                return (double)(merged[(length1 + length2) / 2] + merged[(length1 + length2) / 2 - 1]) / 2;
            }
            else
            {
                return (double)merged[(length1 + length2) / 2];
            }
        }
    }
}
