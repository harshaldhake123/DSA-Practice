// Last updated: 9/9/2025, 3:53:04 PM
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return false;
        }
        var set = new HashSet<int>();
        foreach(var elem in nums) {
            if(set.Contains(elem)){
                return true;
            }
            set.Add(elem);
        }
        return false;
    }
}