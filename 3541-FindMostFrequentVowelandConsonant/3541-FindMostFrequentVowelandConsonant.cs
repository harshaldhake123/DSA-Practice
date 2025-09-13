// Last updated: 9/13/2025, 9:40:04 PM
public class Solution {
    public int MaxFreqSum(string s) {
        var map=new Dictionary<char,int>();
        var vowels=new char[]{'a','e','i','o','u'};
        var maxConsonents=0;
        var maxVowels=0;
        foreach(var c in s){
            if(!map.ContainsKey(c)) map.Add(c,0);
            map[c]++;
            Console.WriteLine(c+"\t"+map[c]);
                if(c=='a'||c=='e'||c=='i'||c=='o'||c=='u'){
                    maxVowels=Math.Max(map[c],maxVowels);
                }else{
                    maxConsonents=Math.Max(map[c],maxConsonents);
                }
            }
        return maxConsonents+maxVowels;
    }
}