// Last updated: 9/9/2025, 10:12:52 PM
public class Solution {
    public bool IsAnagram(string s, string t) {
          if(s.Length!=t.Length){
            return false;
        }
        var arr=new int[26];
        for(var i=0;i<s.Length;i++){
            arr[s[i]-'a']++;
            arr[t[i]-'a']--;
        }

        foreach(var i in arr){
            if(i > 0){
                return false;
            }
        }
        return true;
    }

    //TC: O(N), SC: O(N)
    public bool IsAnagramUsingHashMap(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        var map=new Dictionary<char,int>();
        foreach(var c in s){
            if(map.ContainsKey(c)){
                map[c]++;
            }else{
                map.Add(c,1);
            }
        }
        foreach(var c in t){
            if(map.ContainsKey(c)){
                map[c]--;
            }
            else{
                return false;
                }
        }

        foreach(var kvp in map){
            if(kvp.Value>0){
                return false;
            }
        }
        return true;
    }
}