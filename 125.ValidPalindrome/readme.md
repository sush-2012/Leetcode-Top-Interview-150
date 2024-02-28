# Valid Palindrome

## Problem Statement
Given a string `s`, determine if it is a palindrome after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters.

## Examples:
1. **Input:** `s = "A man, a plan, a canal: Panama"`
   **Output:** `true`
   **Explanation:** After converting to lowercase and removing non-alphanumeric characters, the string becomes "amanaplanacanalpanama", which is a palindrome.

2. **Input:** `s = "race a car"`
   **Output:** `false`
   **Explanation:** After converting to lowercase and removing non-alphanumeric characters, the string becomes "raceacar", which is not a palindrome.

3. **Input:** `s = " "`
   **Output:** `true`
   **Explanation:** The string is empty after removing non-alphanumeric characters. An empty string is considered a palindrome.

## Approaches:
1. **Two-Pointer Method:**
   - Initialize two pointers, `left` and `right`, at the start and end of the string respectively.
   - Compare characters at corresponding positions while ignoring non-alphanumeric characters.
   - Move `left` towards the right and `right` towards the left until they cross each other or a mismatch is found.
   - If no mismatches occur, return true; otherwise, return false.

2. **Using Stacks:**
   - Push only alphanumeric characters onto a stack while iterating through the string.
   - Iterate through the string again and pop characters from the stack to compare with characters from the string.
   - If any mismatches occur, return false. If all characters match or the stack becomes empty before the string is exhausted, return true.

## Implementation Details:
- **Language:** C#
- **Time Complexity:** O(n), where n is the length of the string.
