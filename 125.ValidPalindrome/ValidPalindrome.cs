1. Using 2 pointer

public class Solution {
    public bool IsPalindrome(string s) {
        string lcg = s.ToLower();
        int n = (lcg.Length) -1;
        int i=0;
        while(i<n){
            while (i < n && !char.IsLetterOrDigit(lcg[i]))
                i++;
            while (i < n && !char.IsLetterOrDigit(lcg[n]))
                n--;
            /*while(l<r && (s[l]<'a'||s[l]>'z') && (s[l]<'0'||s[l]>'9'))
                l++;
            while(l<r && (s[r]<'a'||s[r]>'z') && (s[r]<'0'||s[r]>'9'))
                r--; */
            if(lcg[i] != lcg[n]){
                return false;
            }
            i++;
            n--;
            
        }
        return true;
    }
}

2. Using Stack data structure
In C#, you can use the System.Collections.Generic.Stack<T> class, 
which is a predefined stack data structure provided by the .NET framework.

public class Solution {
    public bool IsPalindrome(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s){
            if(char.IsLetterOrDigit(c)){
                stack.Push(char.ToLower(c));
            }
        }
        foreach(char c in s){
            if(char.IsLetterOrDigit(c)){
                if(stack.Count ==0 || stack.Pop() != char.ToLower(c)){
                    return false;
                }
            }
        }
        return true;
    }
}