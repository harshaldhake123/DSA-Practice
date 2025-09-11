// Last updated: 9/11/2025, 11:01:25 PM
public class Solution {
    public int MissingNumber(int[] nums) {
        var frequency=new int[nums.Length+1];
        foreach(var num in nums){
            frequency[num]++;
        }
        for(int i=0;i<frequency.Length;i++){
            if(frequency[i]==0){
                return i;
            }
        }
        return -1;
    }
}