# Problem Statement

Given an integer array `nums` and an integer `val`, remove all occurrences of `val` in `nums` in-place. 
The order of the elements may be changed. Then return the number of elements in `nums` which are not equal to `val`.

## Examples

**Example 1:**

Input:
nums = [3,2,2,3], val = 3

Output:
2

Explanation:
Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores).

**Example 2:**

Input:
nums = [0,1,2,2,3,0,4,2], val = 2

Output:
5

Explanation:
Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
Note that the five elements can be returned in any order.
It does not matter what you leave beyond the returned k (hence they are underscores).


# Solution: Removing Elements from an Array - Two-Pointer Approach

## Description

This solution offers an optimized approach for removing elements from an array in C# without using additional data structures like `List<T>`. 
It employs a two-pointer technique, where one pointer (`i`) iterates through the original array, and the other pointer (`j`) tracks the position
where the next non-removed element should be placed. 

## Algorithm

1. Initialize two pointers, `i` and `j`, to 0.
2. Iterate through the array with `i`.
3. If `nums[i]` is not equal to the target value to be removed (`val`), copy `nums[i]` to `nums[j]` and increment `j`.
4. Repeat steps 2-3 until the end of the array.
5. The value of `j` after iteration represents the new length of the array without the removed elements.

## Example

Consider the input array `nums = [3, 2, 2, 3]` and the target value `val = 3`. After applying the two-pointer approach
, the output will be `2`, and the modified array will be `nums = [2, 2]`.

## Complexity Analysis

- Time Complexity: O(n) - We iterate through the array once.
- Space Complexity: O(1) - No extra space is used; the modification is done in place.

## Usage

This solution can be applied when you need to efficiently remove elements from an array without using additional data structures,
especially in scenarios where memory usage is a concern.
