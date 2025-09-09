// Last updated: 9/9/2025, 4:34:17 PM
public class Solution {
    public int MinimumOperations(int[] nums) {
        /*
        Intuition:
        - Each unique non-zero number will require one operation to eliminate.
        - Duplicates don't matter because they get eliminated together.
        - Zeros require no operation.

        Example: [1,5,0,3,5]
        Step 1: Remove duplicates -> [1,3,5]
        Step 2: Ignore zeros -> [1,3,5]
        Step 3: Each unique value takes one operation:
            - Subtract 1 -> [0,4,0,2,4]
            - Subtract 2 -> [0,2,0,0,2]
            - Subtract 2 -> [0,0,0,0,0]
        Total operations = 3 (same as number of unique non-zero values)
        */

        var set = new HashSet<int>();
        foreach (var n in nums) {
            if (n > 0) {
                set.Add(n);
            }
        }

        return set.Count;
    }
}
