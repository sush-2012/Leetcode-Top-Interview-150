1. Two Pointer Approach
public class Solution {
    public int RemoveDuplicates(int[] nums) {

        int n= nums.Length;
        int k=0;
        for(int i=1;i<n;i++){
            if(nums[i] != nums[i-1]){
                k++;
                nums[k] = nums[i];
            }
        }
        return k+1;
    }
}

2. Brute force appoach
public class Solution {
    public int RemoveDuplicates(int[] nums) {

        int n= nums.Length;
        int k=0;
        for(int i=0;i<n;i++){
            bool isDuplicate = false;
            for(int j=0;j<i;j++){
                if(nums[j] == nums[i]){
                    isDuplicate = true;
                    break;
                }
            }
            if(!isDuplicate){
                nums[k]= nums[i];
                k++;
            }
        }
        return k;
    }
}