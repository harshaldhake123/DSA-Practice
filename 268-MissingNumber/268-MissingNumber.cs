// Last updated: 9/11/2025, 11:11:12 PM
public class Solution {
    public int MissingNumber(int[] nums) {
    var xorSum=0;
        foreach(var num in nums){
           xorSum^=num;
        }
        var expectedsum=0;
        for(int i=1;i<=nums.Length;i++){
           expectedsum^=i;
        }
        return xorSum^expectedsum;
    }
}