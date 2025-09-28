// Last updated: 9/28/2025, 9:48:05 PM
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        var result = new List<int>();
        int i = 0, j = 0;

        while (i < nums1.Length && j < nums2.Length) {
            if (i > 0 && nums1[i] == nums1[i - 1]) {
                i++;
                continue;
            }

            if (j > 0 && nums2[j] == nums2[j - 1]) {
                j++;
                continue;
            }

            if (nums1[i] < nums2[j]) {
                i++;
            } else if (nums1[i] > nums2[j]) {
                j++;
            } else {
                result.Add(nums1[i]);
                i++;
                j++;
            }
        }
        return result.ToArray();
    }
    
    //TC: O(M+N), SC:O(M+N)
    public int[] IntersectionWithSet(int[] nums1, int[] nums2) {
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