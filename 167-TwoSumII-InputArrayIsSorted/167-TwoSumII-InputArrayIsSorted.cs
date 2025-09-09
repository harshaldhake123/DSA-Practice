// Last updated: 9/9/2025, 10:36:28 PM
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var left=0;
        var right=nums.Length-1;
        while(left < right){
            if(nums[left]+nums[right]==target){
                return [left+1,right+1];
            }
            if(nums[left]+nums[right]<target){
                left++;
            }
            else{
                right--;
            }
        }
        return [1,1];
    }
}