﻿namespace LeetCodeTraining.MedianOfTwoSortedArrays6
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[] merged = new int[m + n];

            int i = 0, j = 0, k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    merged[k++] = nums1[i++];
                }
                else
                {
                    merged[k++] = nums2[j++];
                }
            }

            while (i < m)
            {
                merged[k++] = nums1[i++];
            }

            while (j < n)
            {
                merged[k++] = nums2[j++];
            }

            if ((m + n) % 2 == 0)
            {
                return (double)(merged[(m + n) / 2] + merged[(m + n) / 2 - 1]) / 2;
            }
            else
            {
                return (double)merged[(m + n) / 2];
            }
        }
    }
}
