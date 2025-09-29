// Last updated: 9/29/2025, 10:45:09 PM
public class Solution {
    public int Rob(int[] nums) {
        var loot=new Dictionary<int,int>();
        return Rob(nums,nums.Length-1,loot);
    }

    private int Rob(int[] nums,int i,Dictionary<int,int> loot){
        if(i<0){
            return 0;
        }
        if(loot.ContainsKey(i)){
            return loot[i]; 
        }
        var result= Math.Max(Rob(nums,i-2,loot)+nums[i],Rob(nums,i-1,loot));
        loot[i]=result;
        return result;
    }
}