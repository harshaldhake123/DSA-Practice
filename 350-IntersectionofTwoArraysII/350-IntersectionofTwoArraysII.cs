// Last updated: 9/28/2025, 9:13:39 PM
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var map1=new Dictionary<int,int>();
        var map2=new Dictionary<int,int>();
        foreach(var n in nums1){
            if(!map1.ContainsKey(n)) map1.Add(n,0);
            map1[n]++;
        }

        foreach(var n in nums2){
            if(!map2.ContainsKey(n)) map2.Add(n,0);
            map2[n]++;
        }
        var result=new List<int>();
        foreach(var kvp in map1){
            if(map2.ContainsKey(kvp.Key)){
                var occurances=Math.Min(map1[kvp.Key],map2[kvp.Key]);
                while(occurances>0){
                    result.Add(kvp.Key);
                    occurances--;
                }
            }
        }
        return result.ToArray();
    }
}