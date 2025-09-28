// Last updated: 9/28/2025, 9:53:16 PM
public class Solution {
    //TC: O(m+n), SC: O(m+n)
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        
        var diff1 = new List<int>();
        foreach (var num in set1) {
            if (!set2.Contains(num)){
                diff1.Add(num);
            }
        }
        
        var diff2 = new List<int>();
        foreach (var num in set2) {
            if (!set1.Contains(num)) {
                diff2.Add(num);
            }
        }
        return new List<IList<int>>{diff1,diff2};
    }
}