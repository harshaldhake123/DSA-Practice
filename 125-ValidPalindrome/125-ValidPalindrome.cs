// Last updated: 9/8/2025, 11:10:45 PM
public class Solution {
    public bool IsPalindrome(string s) {
        // two pointers, 
        // if not between ascii range then move that pointer
        var left=0;
        var right=s.Length-1;
        while(left<right){
            /*
            Uppercase letters (A-Z): Decimal values 65 to 90.
            Lowercase letters (a-z): Decimal values 97 to 122.
            Digits (0-9): Decimal values 48 to 57.
            */
            if(!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }
            
            if(char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
}