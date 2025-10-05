// Last updated: 10/5/2025, 8:37:28 PM
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result=string.Empty;
        if (strs.Length == 0) return result;

        // Select the first(or any random) string for prefix comparison
        var first=strs[0];

        for(int i=0;i<first.Length;i++){
            var c=first[i];    
            // Compare current char with all other strings for that position
            foreach(var s in strs){
                if(i==s.Length || s[i]!=c){
                    return result; // Mismatch or end of string reached, so longest prefix can't exceed the min length string element
                }
            }    
            // If all strings have the char at the position, add char to result
            result+=c;
        }
        return result;
    }
}