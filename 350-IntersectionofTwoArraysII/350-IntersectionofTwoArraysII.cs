// Last updated: 9/28/2025, 9:31:03 PM
public class Solution {
    //Sort Method, TC:O(NlogN+ MlogM), SC: O(min(m,n))
    public int[] Intersect(int[] nums1, int[] nums2) {//Sort method
        Array.Sort(nums1); //O(mlogm)
        Array.Sort(nums2);//O(nlogn)
        var i=0;
        var j=0;
        var result=new List<int>();
        while(i<nums1.Length && j<nums2.Length){
            if(nums1[i]<nums2[j]){
                i++;
            }else if(nums1[i]>nums2[j]){
                j++;
            }else{
                result.Add(nums1[i]);
                i++;
                j++;
            }
        }
        return result.ToArray();
    }

    public int[] IntersectWithHashMap(int[] nums1, int[] nums2) {
        // Use a map to count the occurrences in the smaller array
        // to use less space
        if (nums1.Length > nums2.Length) {
            return Intersect(nums2, nums1);
        }

        var map = new Dictionary<int, int>();
        foreach (var num in nums1) {
            if (!map.ContainsKey(num)) {
                map.Add(num, 0);
            }
            map[num]++;
        }

        var result = new List<int>();
        foreach (var num in nums2) {
            if (map.ContainsKey(num) && map[num] > 0) {
                result.Add(num);
                map[num]--; // Decrement the count for each match in nums2
            }
        }
        return result.ToArray();
    }
}
