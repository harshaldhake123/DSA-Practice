// Last updated: 1/18/2026, 2:41:00 PM
1public class Solution {
2    public int[] TwoSum(int[] nums, int target) {
3        var left=0;
4        var right=nums.Length-1;
5        while(left < right){
6            if(nums[left]+nums[right]==target){
7                return [left+1,right+1];
8            }
9            if(nums[left]+nums[right]<target){
10                left++;
11            }
12            else{
13                right--;
14            }
15        }
16        return [1,1];
17    }
18}