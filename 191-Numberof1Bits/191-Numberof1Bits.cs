// Last updated: 9/22/2025, 10:07:15 PM
public class Solution {
    public int HammingWeight(int n) {
        int count=0;
        while(n>0){
            n&=(n-1);
            count++;
        }
        return count;
    }
}