# Remove Duplicates from Sorted Array II

## Problem Statement
Given an integer array `nums` sorted in non-decreasing order, remove some duplicates in-place such that each unique element appears at most twice.
The relative order of the elements should be kept the same. It is required to modify the input array in-place and return the length of the modified array.
The modified array should hold the final result in its first part, and it does not matter what is left beyond the returned length.

### Examples:
#### Example 1:
Input: nums = [1,1,1,2,2,3]  
Output: 5  
Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2, and 3 respectively.

#### Example 2:
Input: nums = [0,0,1,1,1,1,2,3,3]  
Output: 7  
Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3, and 3 respectively.

## Approach
### Single Loop Iteration:
The solution utilizes a single loop iteration over the array of numbers.

### Comparison Logic:
For each element num in the array, it checks whether the current position i is less than 2 (indicating the first or second element)
or if num is greater than the element two positions behind i. If either condition is true, num is included in the modified array,
and i is incremented accordingly.

## Algorithm:
1. Initialize an integer variable `i` to keep track of the position where the next unique element should be placed. Initialize it to 0.
2. Iterate through each element `num` in the array using a foreach loop.
    - Check if `i` is less than 2 or if `num` is greater than the element two positions behind `i`.
    - If either condition is true, include `num` in the modified array, and increment `i`.
3. Return the value of `i`, representing the length of the modified array containing unique elements.

## Time Complexity
The time complexity of the solution is O(n), where n is the length of the input array `nums`.
This is because the solution iterates through the entire array exactly once.

## Space Complexity
The space complexity of the solution is O(1). This is because the solution modifies the input array in-place without using any additional data structures
that grow with the size of the input.
