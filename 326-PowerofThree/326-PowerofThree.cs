// Last updated: 10/7/2025, 9:58:12 PM
public class Solution {
    public bool IsPowerOfThree(int n) {
        if(n==1) return true;
        if(n<3) return false;
        while(n%3==0){
            n/=3;
            if(n==1){
                return true;
            }
        }
        return false;
    }
}