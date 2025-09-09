// Last updated: 9/9/2025, 4:07:32 PM
public class Solution {
    public string FindValidPair(string s) {
        var map=new Dictionary<char,int>();
        foreach(var c in s){
            if(map.ContainsKey(c)){
                map[c]++;
            } else{
                map.Add(c,1);
            }
        }

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