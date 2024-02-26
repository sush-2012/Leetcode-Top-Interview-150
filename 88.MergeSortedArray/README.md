# Merge Sorted Array

## Problem Description
You are given two integer arrays `nums1` and `nums2`, sorted in non-decreasing order, 
and two integers `m` and `n`, representing the number of elements in `nums1` and `nums2` respectively. 
Merge `nums1` and `nums2` into a single array sorted in non-decreasing order.

### Examples

**Example 1:**

Input: 
nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3

Output: 
[1,2,2,3,5,6]

Explanation: 
The arrays we are merging are `[1,2,3]` and `[2,5,6]`. 
The result of the merge is `[1,2,2,3,5,6]` with the underlined elements coming from `nums1`.

**Example 2:**

Input: 
nums1 = [1], m = 1, nums2 = [], n = 0

Output: 
[1]

Explanation: 
The arrays we are merging are `[1]` and `[]`. 
The result of the merge is `[1]`.

## Approaches

### Brute-Force Approach

Add each element from `nums1` to the solution array, then add each element from `nums2` to the solution array,
and finally sort the solution array.

### Two Pointer Approach

We can start with two pointers `i` and `j`, initialized to `m-1` and `n-1`, respectively.
We will also have another pointer `k` initialized to `m+n-1`, which will be used to keep track of the position in `nums1`
where we will be placing the larger element. Then we can start iterating from the end of the arrays `i` and `j`,
and compare the elements at these positions. We will place the larger element in `nums1` at position `k`,
and decrement the corresponding pointer `i` or `j` accordingly. We will continue doing this until we have
iterated through all the elements in `nums2`. If there are still elements left in `nums1`,
we don't need to do anything because they are already in their correct place.

## Complexity Analysis

**Time complexity:** `O(m+n)`

We are iterating through both arrays once, so the time complexity is `O(m+n)`.

**Space complexity:** `O(1)`

We are not using any extra space, so the space complexity is `O(1)`.
