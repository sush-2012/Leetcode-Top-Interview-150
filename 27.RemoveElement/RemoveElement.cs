1. public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i =0;
        int n = nums.Length;
        while(i<n){
            if(nums[i] == val){
                nums[i] = nums[n-1];
                n--;
            }else{
                i++;
            }
        }
        return n;
    }
}

2. public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i =0;
        int j = 0; // Pointer for tracking the position to place the next non-removed element

        while (i < nums.Length)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++; // Increment j only if the current element is not equal to val
            }
            i++; // Always increment i
        }

        return j;
    }
}