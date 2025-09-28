// Last updated: 9/28/2025, 9:19:42 PM
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
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
