// Last updated: 9/9/2025, 12:08:26 PM
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            var complement=target-nums[i];

            if(map.ContainsKey(complement)){
                return [map[complement],i];
            }
            map[nums[i]]=i;
        }
        return [0,0];
    }
}