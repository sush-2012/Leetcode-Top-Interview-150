# Remove Duplicates from Sorted Array

Given an integer array `nums` sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
The relative order of the elements should be kept the same. Then return the number of unique elements in `nums`.

### Example 1:
Input: nums = [1,1,2]
Output: 2
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.

### Example 2:
Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.

## Approach 1: Two Pointer Algorithm

### Algorithm:
1. Initialize two pointers, `k` and `i`, where `k` represents the index for the new sorted array without duplicates, and `i` iterates through the original array `nums`.
2. Start iterating `i` from index 1 to the end of the array.
3. Compare the current element `nums[i]` with the previous element `nums[i-1]`.
4. If `nums[i]` is not equal to `nums[i-1]`, it means a new distinct element is found.
   - Increment `k` to denote the index for the next distinct element.
   - Assign the value of `nums[i]` to the `k`th index of `nums`.
5. Repeat steps 3-4 until the end of the array is reached.
6. Return `k+1`, which represents the length of the array without duplicates.

### Complexity Analysis:
- Time Complexity: O(n) - We only iterate through the array once.
- Space Complexity: O(1) - No extra space is used other than a few variables.

## Approach 2: Brute Force Approach

A brute force approach for removing duplicates from a sorted array would involve comparing each element with every other element to detect and remove duplicates. However, this approach is highly inefficient, especially for large arrays, as it would result in quadratic time complexity.

### Algorithm:
1. Iterate through each element in the array.
2. For each element, iterate through the array again to find duplicates.
3. When a duplicate is found, remove it from the array.
4. Continue until all duplicates are removed.
5. Return the modified array's length.

### Complexity Analysis:
- Time Complexity: O(n^2) - Nested loops result in quadratic time complexity as each element is compared with every other element.
- Space Complexity: O(1) - No extra space is used other than a few variables for looping.

While this approach is straightforward, it's highly inefficient and impractical for large arrays due to its quadratic time complexity.
The two-pointer approach or the approach that modifies the array in place are more efficient alternatives.
