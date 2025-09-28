// Last updated: 9/28/2025, 9:39:50 PM
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) {
            return Intersection(nums2, nums1);
        }

        var set = new HashSet<int>();
        foreach (var num in nums1) {
            set.Add(num);
        }
        var result = new HashSet<int>();
        foreach (var num in nums2) {
            if(set.Contains(num))
                result.Add(num);
        }
        
        return result.ToArray();
    }
}