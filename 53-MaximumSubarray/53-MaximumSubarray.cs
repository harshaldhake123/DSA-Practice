// Last updated: 9/14/2025, 10:26:41 PM
public class Solution {
    public int MaxSubArray(int[] nums) {
        // brute
        var maxSum=nums[0];
        var sum=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
            maxSum=Math.Max(sum,maxSum);
            if(sum<0) sum=0;
        }
        return maxSum;
    }
}