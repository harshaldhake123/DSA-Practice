// Last updated: 10/15/2025, 9:37:10 PM
public class Solution {
    //O(nLogn)
    public int Search(int[] nums, int target) {
        var low=0;
        var high=nums.Length-1;
        while(low <= high){
            var mid=low + (high-low)/2;
            if(nums[mid]<target){
                low=mid+1;
            }else if(nums[mid] > target){
                high=mid-1;
            }else{
                return mid;
            }
        }
        return -1;
    }
}