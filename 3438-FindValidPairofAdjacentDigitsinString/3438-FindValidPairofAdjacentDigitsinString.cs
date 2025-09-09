// Last updated: 9/9/2025, 4:05:09 PM
public class Solution {
    public string FindValidPair(string s) {
        var map=new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++){
            if(map.ContainsKey(s[i])){
                map[s[i]]++;
                continue;
            }
            map.Add(s[i],1);
        }
        // Now I have a frequency map.
        for(int i=0;i<s.Length-1;i++){
            var current=s[i]-'0';
            var next=s[i+1]-'0';
            if(current==next){
                continue;
            }
            if(map[s[i]]==current && map[s[i+1]]==next){
                return current+""+next;
            }
        }
        return string.Empty;
    }
}