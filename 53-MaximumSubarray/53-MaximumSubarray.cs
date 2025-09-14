// Last updated: 9/14/2025, 11:31:20 PM
public class Solution {
    
    public int MaxSubArray(int[] nums) {
        // Kadane's algorithm: do not carry negative burden to the future
        // Also printing the subarray indexes for followup
        var maxSum=nums[0];
        var sum=0;
        int start=0;
        int maxStart=0;
        int maxEnd=0;
        for(var i=0;i<nums.Length;i++){
            if(sum==0) start=i;
            sum+=nums[i];
            if(sum > maxSum){
                maxSum=sum;
                maxStart=start;
                maxEnd= i;
            }
            maxSum = Math.Max(sum,maxSum);
            if(sum<0){
                sum=0;
            }
        }
        Console.WriteLine(maxStart+"\t"+maxEnd);
        return maxSum;
    }

    public int MaxSubArrayBruteImproved(int[] nums) {
        // brute force O(n2)
        // Sum of arr[i...j] = (sum of arr[i...j-1]) + arr[j]
        // TLE
        var maxSum=nums[0];
        for(int i=0;i<nums.Length;i++){
            var sum=0;
            for(int j=i;j<nums.Length;j++){
                sum+=nums[j];
                maxSum=Math.Max(sum,maxSum);
            }
        }
        return maxSum;
    }
   
    public int MaxSubArrayBrute(int[] nums) {
        // brute force O(n3)
        // TLE
        var maxSum=nums[0];
        var sum=0;
        for(int i=0;i<nums.Length;i++){
            //[-2,1,-3,4,-1,2,1,-5,4]
            //eg.    |
            for(int j=i;j<nums.Length;j++){
                //[-2,1,-3,4,-1,2,1,-5,4]
                //eg.             |
                sum=0;
                for(int k=i;k<=j;k++){
                    //[-2,1,-3,4,-1,2,1,-5,4]
                    //       |--------|
                    sum+=nums[k];
                    maxSum=Math.Max(sum,maxSum);
                }
            }
        }
        return maxSum;
    }
}