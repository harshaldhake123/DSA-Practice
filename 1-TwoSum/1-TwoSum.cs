// Last updated: 1/18/2026, 2:38:46 PM
1public class Solution {
2    public int[] TwoSum(int[] nums, int target) {
3        var map=new Dictionary<int,int>();
4
5        for(int i=0;i<nums.Length;i++){
6            var complement=target-nums[i];
7
8            if(map.ContainsKey(complement)){
9                return [map[complement],i];
10            }
11            map[nums[i]]=i;
12        }
13        return [0,0];
14    }
15}