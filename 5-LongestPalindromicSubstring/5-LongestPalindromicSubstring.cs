// Last updated: 10/9/2025, 9:29:12 PM
public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length <= 1) return s;
        var result="";
        for(int i=0;i<s.Length;i++){
            string oddPalindrome = ExpandAroundCenter(s, i, i);
            if(oddPalindrome.Length > result.Length){
                result=oddPalindrome;
            }
            string evenPalindrome = ExpandAroundCenter(s, i, i+1);
            if(evenPalindrome.Length > result.Length){
                result=evenPalindrome;
            }
        }
        return result;
    }

    private string ExpandAroundCenter(string s, int left, int right){
        while(left >=0 && right <s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        return s.Substring(left+1, right-left-1);
    }
}