// Last updated: 9/28/2025, 10:38:02 PM
public class Solution {
    public int StrStr(string haystack, string needle) {
        if (string.IsNullOrEmpty(needle)) return -1;
        if (needle.Length > haystack.Length) return -1;

        for(int i=0;i<=haystack.Length-needle.Length;i++){
            var matched=true;
            for(var j=0;j<needle.Length;j++){
                if(haystack[i+j]!=needle[j]){
                    matched=false;
                    break;
                }
            }
            if(matched){
                return i;
            }
        }
        return -1;
    }
}