// Last updated: 9/11/2025, 11:05:37 PM
public class Solution {
    public int MissingNumber(int[] nums) {
    var actualSum=0;
        foreach(var num in nums){
           actualSum+=num;
        }
        var expectedSum=nums.Length*(nums.Length+1)/2;

        return expectedSum-actualSum;
    }
}