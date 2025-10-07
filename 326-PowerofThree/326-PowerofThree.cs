// Last updated: 10/7/2025, 9:59:28 PM
public class Solution {
    public bool IsPowerOfThree(int n) {
        if(n>1){
            while(n%3==0){
                n/=3;
            }
        }
        return n==1;
    }
}