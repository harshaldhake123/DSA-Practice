// Last updated: 9/22/2025, 10:04:59 PM
public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        var map=new Dictionary<int,int>();
        var maxFreq=-1;

        foreach(var num in nums){
            if(map.ContainsKey(num)){
                map[num]++;
            }else{
                map.Add(num,1);
            }
        }
        foreach(var kvp in map){
            if(kvp.Value > maxFreq){
                maxFreq=kvp.Value;
            }
        }
        var count=0;
        foreach(var kvp in map){
            if(kvp.Value == maxFreq){
                count++;
            }
        }
        return count * maxFreq;
    }
}