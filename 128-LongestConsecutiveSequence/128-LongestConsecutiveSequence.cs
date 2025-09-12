// Last updated: 9/12/2025, 9:49:19 PM
public class Solution {
    public int LongestConsecutive(int[] nums) {
        var maxCount=0;
        var set=new HashSet<int>();
        foreach(var n in nums){
            set.Add(n);
        }
        foreach(var num in set){
            var count=1;
            var n=num;
            if(set.Contains(n-1)){ // its part of existing sequence
                count++;
                continue;
            }
            count=1;
            while(set.Contains(n+1)){
                n++;
                count++;
            }
            maxCount=Math.Max(maxCount,count);
        }
        return maxCount;
    }

public int LongestConsecutiveBruteForce(int[] nums) {
        var maxCount=0;
        foreach(var n in nums){
            var count=1;
            var num=n;
            //while we find next consecutive elements, keep incrementing count.
            //if we don't find, then break the loop and check next number
            while(Search(nums,num+1)){
                num++;
                count++;
            }
            maxCount=Math.Max(count,maxCount);
        }
        return maxCount;
    }


    private bool Search(int[] nums,int k){
        foreach(var n in nums){
            if(n==k){
                return true;
            }
        }
        return false;
    }
}