// Last updated: 9/12/2025, 10:14:59 PM
public class Solution {
    public int LongestConsecutive(int[] nums) {
        var maxCount=0;
        var set=new HashSet<int>();
        foreach(var n in nums){
            set.Add(n);
        }
        foreach(var num in set){
            var n=num;
            if(!set.Contains(n-1)){ // its a new sequence
                var count=1;
                while(set.Contains(n+1)){
                    n++;
                    count++;
                }
                maxCount=Math.Max(maxCount,count);
            }
        }
        return maxCount;
    }

    // Sorting array
     public int LongestConsecutiveSorting(int[] nums) {
        if(nums.Length==0){
            return 0;
        }
        var maxCount=1;
        var count=1;
        Array.Sort(nums);
        for(int i=1;i<nums.Length;i++){
            if(nums[i-1]==nums[i]){ //skip if duplicate
                continue;
            }
            if(nums[i]==nums[i-1]+1){ // current is consecutive to last
                count++;
            }else { 
                // sequence broke, so reset count, find max until now
                maxCount=Math.Max(maxCount,count);
                count=1;
            }
        }
        return Math.Max(maxCount,count);;
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