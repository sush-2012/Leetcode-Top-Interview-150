using System;

//Brute Force Approach
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        for (int j = 0, i = m; j < n; j++)
        {
            nums1[i] = nums2[j];
            i++;
        }
        Array.Sort(nums1);
    }
}

//Two-Pointer Approach

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int index1 = m - 1;
        int index2 = n - 1;
        int indexMerged = m + n - 1;

        while (index1 >= 0 && index2 >= 0)
        {
            if (nums1[index1] > nums2[index2])
            {
                nums1[indexMerged] = nums1[index1];
                index1--;
            }
            else
            {
                nums1[indexMerged] = nums2[index2];
                index2--;
            }
            indexMerged--;
        }

        while (index2 >= 0)
        {
            nums1[indexMerged] = nums2[index2];
            index2--;
            indexMerged--;
        }
    }
}