// Last updated: 9/15/2025, 10:19:29 PM
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxLen=0;
        var set=new HashSet<char>();
        var left=0;
        for(int right=0;right<s.Length;right++){
            if(!set.Contains(s[right])){
                maxLen=Math.Max(maxLen,right-left+1);
            } else {
                while(set.Contains(s[right])){
                    set.Remove(s[left]);
                    left++;
                }
            }
            set.Add(s[right]);
        }
        return maxLen;
    }
}